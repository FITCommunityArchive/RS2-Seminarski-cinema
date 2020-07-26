using Cinema.Models.Requests;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch> where TSearch : BaseSearchRequest
    {

        Task<T> Update(int id, TUpdate req);
        T Insert(TInsert req);
    }
}
