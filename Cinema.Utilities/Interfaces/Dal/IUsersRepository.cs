using Cinema.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Utilities.Interfaces.Dal
{
    public interface IUsersRepository : IRepository<ApplicationUser,int>
    {
        ApplicationUser GetUserByEmail(string email);
    }
}
