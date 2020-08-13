using Cinema.Domain.Entities;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IScreeningRepository : IRepository<Screening, int>
    {
        Task<IPagedList<Screening>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm, decimal? price, TimingStatus? status, DateTime? screeningDate);
    }
}
