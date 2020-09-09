using AutoMapper;
using Cinema.Domain.Entities.Identity;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Shared.Constants;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private IConfiguration _config;

        protected readonly IUserRepository _userRepo;
        protected readonly IRepository<ApplicationUserRole, int> _userRoleRepo;
        protected readonly ISeatReservationRepository _seatReservationRepo;
        protected readonly IReservationRepository _reservationRepo;
        protected readonly IRepository<ApplicationRole, int> _roleRepo;
        protected readonly IInvoiceRepository _invoiceRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;
        public UserService(IUnitOfWork unit, IMapper mapper, UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            _unit = unit;
            _userManager = userManager;
            _userRepo = unit.Users;
            _config = config;
            _mapper = mapper;
            _userRoleRepo = unit.Repository<ApplicationUserRole, int>();
            _roleRepo = unit.Repository<ApplicationRole, int>();
            _reservationRepo = unit.Reservations;
            _invoiceRepo = unit.Invoices;
            _seatReservationRepo = unit.SeatReservations;
        }


        [HttpPost]
        public async Task<ApplicationUserDto> InsertAsync(UserInsertRequest model)
        {
            var userIdentity = _mapper.Map<ApplicationUser>(model);


            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (result.Succeeded)
            {
                ApplicationRole role = await _unit.Roles.GetAsync(model.RoleId);
                await _userManager.AddToRoleAsync(userIdentity, role.Name);
            }

            return _mapper.Map<ApplicationUserDto>(userIdentity);
        }

        [HttpPost]
        public async Task<ApplicationUserDto> RegisterAsync(UserRegisterRequest model)
        {
            var userIdentity = _mapper.Map<ApplicationUser>(model);
            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (result.Succeeded)
            {
                ApplicationRole role = await _unit.Roles.GetAsync(-3);
                await _userManager.AddToRoleAsync(userIdentity, role.Name);
            }

            return _mapper.Map<ApplicationUserDto>(userIdentity);
        }

        public async Task<ApplicationUserDto> UpdateAsync(int id, UserUpdateRequest req)
        {
            var user = await _userRepo.GetByIdWithRolesAsync(id);
            user = _mapper.Map(req, user);

            await _userRepo.UpdateAsync(user, id);

            if (user.UserRoles[0].RoleId != req.RoleId)
            {
                var getRoleName = await _roleRepo.GetAsync(req.RoleId);
                await _userManager.RemoveFromRoleAsync(user, user.UserRoles[0].Role.Name);
                await _userManager.AddToRoleAsync(user, getRoleName.Name);
            }

            await _unit.SaveAsync();

            return _mapper.Map<ApplicationUserDto>(user);
        }

        public async Task<bool> ResetPassword(int userId, string newPassword, string token)
        {
            var user = _userManager.Users.Where(x => x.Id == userId).FirstOrDefault();

            var passwordChanged = await _userManager.ResetPasswordAsync(user, token, newPassword);
            if (passwordChanged.Succeeded)
            {
                return true;
            }
            return false;
        }

        public async Task<string> ResetPasswordToken(int userId)
        {
            var user = _userManager.Users.Where(x => x.Id == userId).FirstOrDefault();

            return await _userManager.GeneratePasswordResetTokenAsync(user);
        }

        public async Task<IPagedList<ApplicationUserDto>> GetPagedAsync(UserSearchRequest search)
        {
            var list = await _userRepo.GetPagedAsync(search, search.searchTerm);
            var dtoList = PagedList<ApplicationUserDto>.Map<ApplicationUser>(_mapper, list);

            return dtoList;
        }


        public async Task<ApplicationUserDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            var user = await _userRepo.GetByIdWithRolesAsync(id);
            return _mapper.Map<ApplicationUserDto>(user);
        }


        public async Task<ApplicationUserDto> Authenticate(string userName, string password)
        {
            var user = _userManager.Users.Include(r => r.UserRoles).ThenInclude(u => u.Role).FirstOrDefault(x => x.UserName == userName);

            if (user != null)
            {

                var result = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
                if (PasswordVerificationResult.Success == result)
                {

                    return _mapper.Map<ApplicationUserDto>(user);
                }
            }
            return null;
        }

        #region GenerateJWT  
        /// <summary>  
        /// Generate Json Web Token Method  
        /// </summary>  
        /// <param name="userInfo"></param>  
        /// <returns></returns>  
        public string GenerateJSONWebToken(ApplicationUserDto user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserName),
                new Claim(CinemaClaimTypes.UserId, user.Id.ToString())
            };

            foreach (var role in user.UserRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Role.Name));
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion

        public async Task<string> DecodeJSONWebToken(string token)
        {

            var handler = new JwtSecurityTokenHandler();
            var readToken = handler.ReadJwtToken(token);

            var roleName = readToken.Claims.ToList()[1].Value;
            var user = await _userManager.GetUsersInRoleAsync(roleName);

            return roleName;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _userRepo.DeleteAsync(id);
            await _unit.SaveAsync();

            return true;
        }

        public async Task<List<ReservationDto>> GetUserReservations(int id)
        {
            var reservations = await _reservationRepo.GetReservationsByUserId(id);

            return _mapper.Map<List<ReservationDto>>(reservations);
        }
    }
}
