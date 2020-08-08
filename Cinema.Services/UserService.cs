using AutoMapper;
using Cinema.Domain.Entities.Identity;
using Cinema.Models;
using Cinema.Models.Requests.Users;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Collections.Generic;

namespace Cinema.Services
{
    public class UserService : ICRUDService<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>, IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private IConfiguration _config;

        protected readonly IUserRepository _userRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;
        public UserService(IUnitOfWork unit, IMapper mapper, UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            _unit = unit;
            _userManager = userManager;
            _userRepo = unit.Users;
            _config = config;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<ApplicationUserDto> Insert([FromBody] UserUpsertRequest model)
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
        
        public async Task<ApplicationUserDto> Update(int id, UserUpsertRequest req)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IPagedList<ApplicationUserDto>> GetPagedAsync(UserSearchRequest search)
        {
            var list = await _userRepo.GetPagedAsync(search,search.FirstName,search.LastName);
            var dtoList = PagedList<ApplicationUserDto>.Map<ApplicationUser>(_mapper, list);

            return dtoList;
        }


        public Task<ApplicationUserDto> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
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
                new Claim(ClaimTypes.NameIdentifier,user.UserName)
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
    }
}
