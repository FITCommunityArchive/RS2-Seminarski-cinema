using Cinema.Domain.Entities.Identity;
using Cinema.Dto.ViewModels.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Cinema.Utilities.Factory.ViewModels
{
    public static class UsersViewModelFactory
    {
        public static ApplicationUserIndexVM ToIndexVM(this ApplicationUser user)
        {
            return new ApplicationUserIndexVM
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = user.UserRoles?.First().Role.CreateMaster()
            };
        }

        public static ApplicationUserDetailsVM ToDetailsVM(this ApplicationUser user)
        {
            return new ApplicationUserDetailsVM
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumber = user.PhoneNumber,
                Role = user.UserRoles?.First().Role.CreateMaster()
            };
        }

        public static ApplicationUserCreateVM ToCreateVM(this ApplicationUser user, SelectList roles)
        {
            return new ApplicationUserCreateVM
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumber = user.PhoneNumber,
                RoleId = user.UserRoles?.First().Role.Id,
                Roles = roles
            };
        }
    }
}
