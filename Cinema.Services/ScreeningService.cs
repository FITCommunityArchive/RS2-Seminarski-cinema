using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Models.SpecificModels;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Exceptions;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class ScreeningService : IScreeningService
    {
        protected readonly IScreeningRepository _screeningRepo;
        protected readonly IMovieRepository _movieRepo;
        protected readonly IReservationRepository _reservationRepo;
        protected readonly IRepository<Hall, int> _hallRepo;
        protected readonly IRepository<Seat, int> _seatRepo;
        protected readonly IRepository<SeatReservation, int> _seatReservationRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public ScreeningService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
            _screeningRepo = unit.Screenings;
            _movieRepo = unit.Movies;
            _reservationRepo = unit.Reservations;
            _hallRepo = unit.Repository<Hall, int>();
            _seatRepo = unit.Repository<Seat, int>();
            _seatReservationRepo = unit.Repository<SeatReservation, int>();
        }

        public async Task<ScreeningDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            var entity = await _screeningRepo.GetAsync(id, includes);
            return _mapper.Map<ScreeningDto>(entity);
        }

        public async Task<List<ScreeningDto>> GetAsync(ScreeningSearchRequest search)
        {
            var list = await _screeningRepo.GetAsync(search, search.SearchTerm, search.MovieId, search.Hall, search.Price, search.Status, search.Date);

            var dtoList = _mapper.Map<List<ScreeningDto>>(list);

            foreach(var screening in dtoList)
            {
                screening.TimingStatus = GetTimingStatus(screening);
            }

            return dtoList;
        }

        public async Task<IPagedList<ScreeningDto>> GetPagedAsync(ScreeningSearchRequest search)
        {
            var list = await _screeningRepo.GetPagedAsync(search, search.SearchTerm, search.MovieId, search.Hall, search.Price, search.Status, search.Date);
            var dtoList = PagedList<ScreeningDto>.Map<Screening>(_mapper, list);

            foreach (var screening in dtoList.Data)
            {
                screening.TimingStatus = GetTimingStatus(screening);
            }

            return dtoList;
        }

        public async Task<List<SeatingModel>> GetSeatingAsync(int id)
        {
            Screening screening = await _screeningRepo.GetAsync(id);

            IEnumerable<Reservation> screeningReservations = await _reservationRepo.GetByScreeningIdAsync(id);

            //gets reserved seats first
            List<SeatingModel> screeningSeats = screeningReservations.SelectMany(x => x.SeatReservations)
                                                                          .Select(x => new SeatingModel
                                                                          {
                                                                              IsReserved = true,
                                                                              Seat = _mapper.Map<SeatDto>(x.Seat)
                                                                          }).ToList();

            //gets all seats
            IEnumerable<Seat> hallSeats = await _seatRepo.GetAsync(x => x.HallId == screening.HallId);
            IEnumerable<Seat> freeSeats = hallSeats.Where(x => !screeningSeats.Select(y => y.Seat.Id).Contains(x.Id)).ToList();

            foreach (Seat seat in freeSeats)
            {
                SeatingModel seatingModel = new SeatingModel
                {
                    IsReserved = false,
                    Seat = _mapper.Map<SeatDto>(seat)
                };

                screeningSeats.Add(seatingModel);
            }

            return screeningSeats.OrderBy(x => x.Seat.SeatNumber).ToList();
        }

        public async Task<bool> AreSeatsFreeAsync(int id, IEnumerable<int> seatIds)
        {
            Screening screening = await _screeningRepo.GetAsync(id);
            IEnumerable<SeatReservation> screeningReservations = await _seatReservationRepo.GetAsync(x => x.Reservation.ScreeningId == id);

            foreach (var seatId in seatIds)
            {
                if (screeningReservations.Select(x => x.SeatId).Contains(seatId))
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> IsSeatReservedAsync(int id, int seatId)
        {
            Screening screening = await _screeningRepo.GetAsync(id);
            IEnumerable<SeatReservation> screeningReservations = await _seatReservationRepo.GetAsync(x => x.Reservation.ScreeningId == id);

            return screeningReservations.Select(x => x.SeatId).Contains(seatId);
        }

        private TimingStatus GetTimingStatus(ScreeningDto screening)
        {
            if (screening.DateAndTime > DateTime.UtcNow)
            {
                return TimingStatus.SCHEDULED;
            }
            else
            {
                return TimingStatus.STARTED;
            }
        }

        public async Task<ScreeningDto> InsertAsync(ScreeningUpsertRequest req)
        {
            var screening = _mapper.Map<Screening>(req);

            if (!ValidateScreeningDate(screening))
            {
                throw new ScreeningAvailabilityException(Shared.Constants.ValidationMessages.DATE_NOT_FUTURE);
            }

            /* // Uncomment after setting identity entities with id key
            if (!await ValidateScreeningHallAvailabilityAsync(screening))
            {
                throw new ScreeningAvailabilityException(Shared.Constants.ValidationMessages.HALL_ALREADY_OCCUPIED);
            }*/

            await _screeningRepo.InsertAsync(screening);
            await _unit.SaveAsync();

            var dto = _mapper.Map<ScreeningDto>(screening);
            return dto;
        }

        public async Task<ScreeningDto> UpdateAsync(int id, ScreeningUpsertRequest req)
        {
            Screening screening = _mapper.Map<Screening>(req);
            screening.Id = id;

            if (!ValidateScreeningDate(screening))
            {
                throw new ScreeningAvailabilityException(Shared.Constants.ValidationMessages.DATE_NOT_FUTURE);
            }

            /* // Uncomment after setting identity entities with id key
            if (!await ValidateScreeningHallAvailabilityAsync(screening))
            {
                throw new ScreeningAvailabilityException(Shared.Constants.ValidationMessages.HALL_ALREADY_OCCUPIED);
            }*/

            await _screeningRepo.UpdateAsync(screening, id);
            await _unit.SaveAsync();

            var dto = _mapper.Map<ScreeningDto>(screening);
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _screeningRepo.DeleteAsync(id);
            await _unit.SaveAsync();

            return true;
        }

        private bool ValidateScreeningDate(Screening screening)
        {
            return screening.DateAndTime >= DateTime.UtcNow;
        }


        private async Task<bool> ValidateScreeningHallAvailabilityAsync(Screening screening)
        {
            Hall hall = await _hallRepo.GetAsync(screening.HallId, new List<string> { nameof(Hall.Screenings) });
            Movie movie = await _movieRepo.GetAsync(screening.MovieId);

            if (hall == null || movie == null) return false;

            DateTime validatedStartTime = screening.DateAndTime;
            DateTime validatedEndTime = screening.DateAndTime.AddMinutes(movie.Duration);

            var hallScreenings = hall.Screenings.Where(x => x.DateAndTime.Date == validatedStartTime.Date).ToList();

            foreach (var hallScreening in hallScreenings)
            {
                DateTime startTime = hallScreening.DateAndTime;
                DateTime endTime = hallScreening.DateAndTime.AddMinutes(hallScreening.Movie.Duration);

                if (validatedStartTime >= startTime && validatedStartTime <= endTime) return false;
                if (validatedEndTime >= startTime && validatedEndTime <= endTime) return false;
            }

            return true;
        }
    }
}
