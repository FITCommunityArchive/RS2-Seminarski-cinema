using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Utilities.Interfaces.Services;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IUserService : ICRUDService<ApplicationUserDto,UserSearchRequest,UserUpsertRequest,UserUpsertRequest>
    {
        Task<ApplicationUserDto> Authenticate(string userName, string password);
        string GenerateJSONWebToken(ApplicationUserDto user);
        Task<string> DecodeJSONWebToken(string token);
        Task<bool> ResetPassword(int userId, string newPassword, string token);
        Task<string> ResetPasswordToken(int userId);
    }
}
