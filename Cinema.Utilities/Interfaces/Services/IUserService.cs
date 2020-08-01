using Cinema.Domain.Entities.Identity;
using Cinema.Models;
using Cinema.Models.Requests.Users;
using Cinema.Utilities.Interfaces.Services;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IUserService : ICRUDService<ApplicationUserDto,UserSearchRequest,UserUpsertRequest,UserUpsertRequest>
    {
        Task<ApplicationUserDto> Authenticate(string userName, string password);
        string GenerateJSONWebToken(ApplicationUserDto userInfo);
    }
}
