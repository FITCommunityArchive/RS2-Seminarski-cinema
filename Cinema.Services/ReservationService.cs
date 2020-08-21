using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class ReservationService : IReservationService
    {
        protected readonly IReservationRepository _reservationRepo;
        protected readonly IScreeningRepository _screeningRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public ReservationService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
            _reservationRepo = unit.Reservations;
            _screeningRepo = unit.Screenings;
        }

        public Task<ReservationDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IPagedList<ReservationDto>> GetPagedAsync(ReservationSearchRequest search)
        {
            var list = await _reservationRepo.GetPagedAsync(search, search.ReservationId, search.Movie, search.CustomerFullName, search.Price, search.CreatedAt, search.Status);
            var dtoList = PagedList<ReservationDto>.Map<Reservation>(_mapper, list);

            foreach (var reservation in dtoList.Data)
            {
                reservation.Status = GetReservationStatus(reservation);
            }

            return dtoList;
        }

        public Task<ReservationDto> InsertAsync(ReservationUpsertRequest req)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReservationDto> UpdateAsync(int id, ReservationUpsertRequest req)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> ChangeReservationStatus(int id)
        {
            Reservation reservation = await _reservationRepo.GetAsync(id);
            if (reservation == null) return false;

            reservation.IsCancelled = !reservation.IsCancelled;

            await _unit.SaveAsync();

            return true;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        private async Task<bool> ValidateStatusChange(int screeningID)
        {
            Screening screening = await _screeningRepo.GetAsync(screeningID);

            if (screening == null || screening.DateAndTime <= DateTime.UtcNow) return false;

            if (screening.DateAndTime <= DateTime.UtcNow)
            {
                return false;
            }

            return true;
        }

        private ReservationStatus GetReservationStatus(ReservationDto reservation)
        {
            if (reservation.IsCancelled)
            {
                return ReservationStatus.CANCELED;
            }
            else if (reservation.Invoice == null)
            {
                return ReservationStatus.BOOKED;
            }
            else
            {
                return ReservationStatus.PAID;
            }
        }
    }
}
