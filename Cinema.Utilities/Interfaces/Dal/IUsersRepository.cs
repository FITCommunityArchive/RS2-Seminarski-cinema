using Cinema.Domain.Entities.Identity;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IUsersRepository : IRepository<ApplicationUser, int>
    {
        ApplicationUser GetUserByEmail(string email);
    }
}
