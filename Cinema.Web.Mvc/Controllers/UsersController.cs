using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cinema.Authorization;
using Cinema.Authorization.Constants;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO;
using Cinema.DTO.ViewModels.Movies;
using Cinema.DTO.ViewModels.Reviews;
using Cinema.DTO.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Cinema.Services.Factory.ViewModels;
using Cinema.Web.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using Cinema.Services.Enums;

namespace Cinema.Web.Mvc.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class UsersController : BaseController
    {
        public UsersController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index(SortOrder? sortOrder, string sortProperty, string searchString, string currentFilter, int? pageNumber)
        {

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            IQueryable<ApplicationUser> staff = _unit.Users.Get().Where(x => x.UserRoles.First().Role.Name != Roles.User);

            if (!String.IsNullOrEmpty(searchString))
            {
                var leftQuery = staff.Where(x => x.FirstName.Contains(searchString));
                var rightQuery = staff.Where(x => x.LastName.Contains(searchString));

                staff = leftQuery.Union(rightQuery);
            }

            if (sortOrder != null)
            {
                sortOrder = sortOrder == SortOrder.ASC ? SortOrder.DESC : SortOrder.ASC;
                staff = _unit.Users.Sort(staff, sortOrder, sortProperty);
            }
            else
            {
                sortOrder = SortOrder.ASC;
                staff = staff.OrderBy(s => s.FirstName);
            }

            List<ApplicationUserIndexVM> users = await staff.Select(x => x.ToIndexVM()).ToListAsync();

            PaginatedList<ApplicationUserIndexVM> paginatedModel
                = PaginatedList<ApplicationUserIndexVM>.Create(users.AsQueryable(), pageNumber ?? 1, 10, 
                sortOrder, sortProperty, searchString);

            return View(paginatedModel);
        }
    }
}