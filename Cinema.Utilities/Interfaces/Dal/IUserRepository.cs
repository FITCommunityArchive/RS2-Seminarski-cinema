using Cinema.Domain.Entities.Identity;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IUserRepository : IRepository<ApplicationUser, int>
    {
        ApplicationUser GetUserByEmail(string email);
        Task<ApplicationUser> GetByIdWithRolesAsync(int id);
        Task<IPagedList<ApplicationUser>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm);
    }
}
