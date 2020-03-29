using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Users;
using System.Linq;

namespace Cinema.Services.Factory.ViewModels
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
                Role = user.UserRoles?.First().Role.CreateMaster()
            };
        }
    }
}
