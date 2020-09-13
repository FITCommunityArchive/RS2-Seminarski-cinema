using AutoMapper;
using Cinema.Domain.Entities.Identity;
using Cinema.Models.Dtos;
using Cinema.Shared.Constants;
using Cinema.Common.Exceptions;
using Cinema.Common.Interfaces.Dal;
using Cinema.Common.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class AuthService : IAuthService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepo;

        public AuthService(IHttpContextAccessor httpContextAccessor, IUnitOfWork unit, IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _userRepo = unit.Users;
        }

        public async Task<int> GetCurrentUserIdAsync()
        {
            var userNameClaim = _httpContextAccessor.HttpContext.User.FindFirst(CinemaClaimTypes.UserId);
            int.TryParse(userNameClaim.Value, out int userId);

            ApplicationUser user = await _userRepo.GetUserByIdAsync(userId);

            if (user == null)
            {
                throw new NoCurrentUserFoundException();
            }

            return user.Id;
        }

        public async Task<ApplicationUserDto> GetCurrentUserAsync()
        {
            var userNameClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            var userName = userNameClaim?.Value;

            ApplicationUser user = await _userRepo.GetUserByUserNameAsync(userName);

            if (user == null)
            {
                throw new NoCurrentUserFoundException();
            }

            ApplicationUserDto userDto = _mapper.Map<ApplicationUserDto>(user);

            return userDto;
        }
    }
}
