using Cinema.Models.Requests;
using Cinema.Shared.Pagination;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IService<T, TSearch> where TSearch : BaseSearchRequest
    {        
        Task<IPagedList<T>> GetPagedAsync(TSearch search);
        Task<T> GetByIdAsync(int id, ICollection<string> includes = null);
    }
}


