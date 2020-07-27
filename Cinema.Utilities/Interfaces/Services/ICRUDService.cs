using Cinema.Models.Requests;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch> where TSearch : BaseSearchRequest
    {

        Task<T> Update(int id, TUpdate req);
        Task<T> Insert(TInsert req);
    }
}
