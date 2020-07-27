using Cinema.Domain.Entities.Identity;
using Cinema.Shared.Enums;
using Cinema.Utilities.Interfaces.Dal;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Dal.Repository
{
    public class ApplicationUsersRepository : Repository<ApplicationUser, string>
    {
        public ApplicationUsersRepository(ICinemaDbContext context) : base(context) { }

        public override async Task UpdateAsync(ApplicationUser newEnt, string id)
        {
            ApplicationUser oldEnt = await GetAsync(id);

            if (oldEnt != null)
            {
                ApplicationUserRole userRole = oldEnt.UserRoles.First();

                if (userRole != null)
                {
                    userRole.RoleId = newEnt.UserRoles.First().RoleId;
                }

                // Update operations should be handled outside of repositories (in services)
                //_context.Entry(oldEnt).CurrentValues.SetValues(newEnt);
                oldEnt.Update(newEnt);
            }
        }

        public IQueryable<ApplicationUser> Sort(IQueryable<ApplicationUser> query, SortOrder? sortOrder, string sortProperty)
        {
            if (sortOrder == SortOrder.ASC)
            {
                switch (sortProperty)
                {
                    case "FirstName":
                        query = query.OrderBy(s => s.FirstName);
                        break;
                    case "LastName":
                        query = query.OrderBy(s => s.LastName);
                        break;
                    case "Email":
                        query = query.OrderBy(s => s.Email);
                        break;
                    case "Role":
                        query = query.OrderBy(s => s.UserRoles.First().Role.Name);
                        break;
                }
            }
            else
            {
                switch (sortProperty)
                {
                    case "FirstName":
                        query = query.OrderByDescending(s => s.FirstName);
                        break;
                    case "LastName":
                        query = query.OrderByDescending(s => s.LastName);
                        break;
                    case "Email":
                        query = query.OrderByDescending(s => s.Email);
                        break;
                    case "Role":
                        query = query.OrderByDescending(s => s.UserRoles.First().Role.Name);
                        break;
                }
            }

            return query;
        }

    }
}
