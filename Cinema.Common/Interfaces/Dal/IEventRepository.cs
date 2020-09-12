using Cinema.Domain.Entities;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System;
using System.Threading.Tasks;

namespace Cinema.Common.Interfaces.Dal
{
    public interface IEventRepository : IRepository<Event, int>
    {
        Task<IPagedList<Event>> GetPagedAsync(ISearchRequest searchRequest, string title, string author, string promoter, int? typeId, DateTime? eventDate);
    }
}
