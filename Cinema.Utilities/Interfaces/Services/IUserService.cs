using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Utilities.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces
{
    public interface IUserService : ICRUDService<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        Task<ApplicationUserDto> Authenticate(string userName, string password);

        Task<ApplicationUserDto> RegisterAsync(UserRegisterRequest model);
        string GenerateJSONWebToken(ApplicationUserDto user);
        Task<string> DecodeJSONWebToken(string token);
        Task<bool> ResetPassword(int userId, string newPassword, string token);
        Task<string> ResetPasswordToken(int userId);
        Task<List<ReservationDto>> GetUserReservations(int id);
    }
}
