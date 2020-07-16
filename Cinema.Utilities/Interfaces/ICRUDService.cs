using System.Threading.Tasks;

namespace Cinema.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch>
    {

        Task<T> Update(int id, TUpdate req);
        T Insert(TInsert req);
    }
}
