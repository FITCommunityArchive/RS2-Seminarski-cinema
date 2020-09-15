using Cinema.Domain.Entities;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System.Threading.Tasks;

namespace Cinema.Common.Interfaces.Dal
{
    public interface INewsRepository : IRepository<News, int>
    {
        Task<IPagedList<News>> GetPagedAsync(ISearchRequest searchRequest, string title, string author, int? typeId);
    }
}
