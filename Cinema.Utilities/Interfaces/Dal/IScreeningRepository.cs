using Cinema.Domain.Entities;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IScreeningRepository : IRepository<Screening, int>
    {
        Task<IEnumerable<Screening>> GetAsync(ISearchRequest searchRequest, string searchTerm, int? movieId, string hall, decimal? price, TimingStatus? status, DateTime? screeningDate);
        Task<IPagedList<Screening>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm, int? movieId, string hall, decimal? price, TimingStatus? status, DateTime? screeningDate);
        Task<IEnumerable<Screening>> GetWithSeatReservations(ISearchRequest searchRequest, string searchTerm, int? movieId, string hall, decimal? price, TimingStatus? status, DateTime? screeningDate);
    }
}
