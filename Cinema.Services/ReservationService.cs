using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Models.Requests.Reservations;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class ReservationService : IReservationService
    {
        protected readonly IReservationRepository _reservationRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public ReservationService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
            _reservationRepo = unit.Reservations;
        }

        public Task<ReservationDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IPagedList<ReservationDto>> GetPagedAsync(ReservationSearchRequest search)
        {
            var list = await _reservationRepo.GetPagedAsync(search, search.ReservationId, search.CustomerId, search.Price, search.CreatedAt, search.Status);
            var dtoList = PagedList<ReservationDto>.Map<Reservation>(_mapper, list);

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

        public Task<bool> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
