using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
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
        protected readonly IRepository<Hall, int> _hallRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public ScreeningService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
            _screeningRepo = unit.Screenings;
            _movieRepo = unit.Movies;
            _hallRepo = unit.Repository<Hall, int>();
        }

        public async Task<ScreeningDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            var entity = await _screeningRepo.GetAsync(id, includes);
            return _mapper.Map<ScreeningDto>(entity);
        }

        public async Task<IPagedList<ScreeningDto>> GetPagedAsync(ScreeningSearchRequest search)
        {
            var list = await _screeningRepo.GetPagedAsync(search, search.SearchTerm, search.Hall, search.Price, search.Status, search.Date);
            var dtoList = PagedList<ScreeningDto>.Map<Screening>(_mapper, list);

            foreach (var screening in dtoList.Data)
            {
                screening.TimingStatus = GetTimingStatus(screening);
            }

            return dtoList;
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
