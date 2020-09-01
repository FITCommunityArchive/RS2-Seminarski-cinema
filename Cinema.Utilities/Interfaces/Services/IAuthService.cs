
using Cinema.Models.Dtos;
using System.Threading.Tasks;

namespace Cinema.Utilities.Interfaces.Services
{
    public interface IAuthService
    {
        Task<int> GetCurrentUserIdAsync();
        Task<ApplicationUserDto> GetCurrentUserAsync();
    }
}
