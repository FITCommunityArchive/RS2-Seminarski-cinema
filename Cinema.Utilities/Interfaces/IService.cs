using Cinema.Models.Requests;
using Cinema.Shared;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IService<T, TSearch> where TSearch : BaseSearchRequest
    {
        Task<IPagedList<T>> GetPagedAsync(TSearch search);
        Task<T> GetByIdAsync(int id);
    }
}


