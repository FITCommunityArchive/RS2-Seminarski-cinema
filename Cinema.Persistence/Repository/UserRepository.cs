using Cinema.Common.Interfaces.Dal;
using Cinema.Domain.Entities.Identity;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Persistence.Repository
{
    public class UserRepository : Repository<ApplicationUser, int>, IUserRepository
    {
        public UserRepository(ICinemaDbContext context) : base(context) { }

        public async Task UpdateAsync(ApplicationUser newEnt, int id, int roleId)
        {
            ApplicationUser oldEnt = await GetAsync(id);

            if (oldEnt != null)
            {
                ApplicationUserRole userRole = oldEnt.UserRoles.First();

                if (userRole != null)
                {
                    ApplicationUserRole newUserRole = new ApplicationUserRole();
                    var existingUserRole = _context.UserRoles.IgnoreQueryFilters().Where(x => x.UserId == oldEnt.Id && x.RoleId == roleId).FirstOrDefault();

                    if (existingUserRole != null)
                    {
                        existingUserRole.IsDeleted = false;
                        oldEnt.UserRoles.First().IsDeleted = true;
                    }
                    else
                    {
                        newUserRole.RoleId = roleId;
                        newUserRole.UserId = oldEnt.Id;

                        oldEnt.UserRoles.Remove(userRole);
                        oldEnt.UserRoles.Add(newUserRole);
                    }

                }

                // Update operations should be handled outside of repositories (in services)
                _context.Entry(oldEnt).CurrentValues.SetValues(newEnt);
                oldEnt.Update(newEnt);
            }
        }

        public async Task<ApplicationUser> GetByIdWithRolesAsync(int id)
        {
            var entity = await _dbSet.Include(x => x.UserRoles).ThenInclude(x => x.Role)
                                     .FirstOrDefaultAsync(x => x.Id == id);

            return entity;
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

        public async Task<ApplicationUser> GetUserByUserNameAsync(string userName)
        {
            var result = await _dbSet.FirstOrDefaultAsync(x => x.UserName.ToLower() == userName.ToLower());

            return result;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(int userId)
        {
            var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == userId);

            return result;
        }

        public override async Task DeleteAsync(int id)
        {
            ApplicationUser entity = await _dbSet.Include(c => c.UserRoles)
                                                 .Include(c => c.Reservations).ThenInclude(c => c.SeatReservations)
                                                 .Include(c => c.Reservations).ThenInclude(c => c.Invoice)
                                                 .Where(x => x.Id == id).FirstOrDefaultAsync();

            if (entity != null)
            {
                _dbSet.Remove(entity);
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
