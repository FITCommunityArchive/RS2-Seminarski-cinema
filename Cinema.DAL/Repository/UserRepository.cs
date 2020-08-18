using Cinema.Domain.Entities.Identity;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Interfaces.Dal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Dal.Repository
{
    public class UserRepository : Repository<ApplicationUser, string>, IUserRepository
    {
        public UserRepository(ICinemaDbContext context) : base(context) { }

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

        public async Task<IPagedList<ApplicationUser>> GetPagedAsync(ISearchRequest searchRequest, string searchTerm)
        {
            var query = _dbSet.AsQueryable();

            query = ApplyUserFilter(query, searchTerm);

            if (searchRequest.SortOrder != null && searchRequest.SortColumn != null)
            {
                query = ApplySorting(query, searchRequest);
            }

            var pagedList = await ApplyPaginationAsync(query, searchRequest.PageIndex, searchRequest.PageSize);
            return pagedList;
        }

        private IQueryable<ApplicationUser> ApplyUserFilter(IQueryable<ApplicationUser> query, string searchTerm)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.ToLower();

                query = query.Where(x => x.FirstName.ToLower().StartsWith(searchTerm)
                                        || x.LastName.ToLower().StartsWith(searchTerm)
                                        || x.UserName.ToLower().StartsWith(searchTerm)
                                        || x.Email.ToLower().StartsWith(searchTerm)
                                        || x.PhoneNumber.StartsWith(searchTerm));
            }

            return query;
        }

        public ApplicationUser GetUserByEmail(string email)
        {
            var result = _context.Users.SingleOrDefault(e => e.Email == email.ToString());

            return result;
        }

        public ApplicationUser GetUserByUserName(string userName)
        {
            var result = _context.Users.SingleOrDefault(e => e.UserName == userName.ToString());

            return result;
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

        public Task<ApplicationUser> GetAsync(int id, ICollection<string> includes = null)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ApplicationUser entity, int id)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
