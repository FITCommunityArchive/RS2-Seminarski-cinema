using Cinema.Models.Requests;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IService<T, TSearch> where TSearch : BaseSearchRequest
    {
        PagedList<T> GetPaged(TSearch search);
        Task<T> GetById(int id);
    }
}


