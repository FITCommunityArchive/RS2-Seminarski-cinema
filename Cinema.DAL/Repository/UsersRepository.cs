using Cinema.DAL.Data;
using Cinema.Domain.Entities.Identity;
using Cinema.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Repository
{
    public class ApplicationUsersRepository : Repository<ApplicationUser, string>
    {
        public ApplicationUsersRepository(ApplicationDbContext context) : base(context) { }

        public override IQueryable<ApplicationUser> Sort(IQueryable<ApplicationUser> query, SortOrder? sortOrder, string sortProperty)
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
                    case "Role":
                        query = query.OrderByDescending(s => s.UserRoles.First().Role.Name);
                        break;
                }
            }

            return query;
        }

    }
}
