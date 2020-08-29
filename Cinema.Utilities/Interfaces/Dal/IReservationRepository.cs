using Cinema.Domain.Entities;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IReservationRepository : IRepository<Reservation, int>
    {
        Task<IPagedList<Reservation>> GetPagedAsync(ISearchRequest searchRequest, int? reservationId, string movieTitle, string customerFullName, decimal? price, DateTime? createdAt, ReservationStatus? status);
        Task<IEnumerable<Reservation>> GetByScreeningIdAsync(int screeningId, bool isCancelled = false);
    }
}
