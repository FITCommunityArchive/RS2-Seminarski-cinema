using AutoMapper;
using Cinema.Domain.Entities.Identity;
using Cinema.Models;
using Cinema.Models.Requests.Users;
using Cinema.Utilities.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class UserService : BaseCRUDService<ApplicationUserDto, UserSearchRequest, ApplicationUser, UserUpsertRequest, UserUpsertRequest>, IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserService(IUnitOfWork unit, IMapper mapper, UserManager<ApplicationUser> userManager) : base(unit, mapper)
        {
            _userManager = userManager;
        }


        [HttpPost]
        public override async Task<ApplicationUserDto> Insert([FromBody] UserUpsertRequest model)
        {
            var userIdentity = _mapper.Map<ApplicationUser>(model);

            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if(result.Succeeded)
            {
                ApplicationRole role = await _unit.Roles.GetAsync(model.RoleId);
                await _userManager.AddToRoleAsync(userIdentity, role.Name);
            }

            return _mapper.Map<ApplicationUserDto>(userIdentity);
        }
    }
}
