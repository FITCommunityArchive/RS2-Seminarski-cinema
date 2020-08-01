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

namespace Cinema.Services
{
    public class UserService : ICRUDService<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>, IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        protected readonly IUsersRepository _userRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;
        public UserService(IUnitOfWork unit, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _unit = unit;
            _mapper = mapper;
            _userRepo = unit.Users;
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

        public Task<ApplicationUserDto> Update(int id, UserUpsertRequest req)
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
    }
}
