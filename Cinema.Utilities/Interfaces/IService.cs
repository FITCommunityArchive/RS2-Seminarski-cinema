using Cinema.Models.Requests;
using System.Threading.Tasks;
using Cinema.Shared;

namespace Cinema.Utilities.Interfaces
{
    public interface IService<T, TSearch> where TSearch : BaseSearchRequest
    {
        Task<PagedList<T>> GetPagedAsync(TSearch search);
        Task<T> GetByIdAsync(int id);
    }
}


