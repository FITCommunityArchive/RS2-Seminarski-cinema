using Cinema.Authorization.Constants;
using Cinema.Dal.Data;
using Cinema.Domain.Entities.Identity;
using Cinema.Dto.ViewModels.Users;
using Cinema.EmailService;
using Cinema.Utilities.Enums;
using Cinema.Utilities.Factory;
using Cinema.Utilities.Factory.ViewModels;
using Cinema.Utilities.Helpers;
using Cinema.Web.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class UsersController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<UsersController> _logger;
        private readonly IEmailSender _emailSender;

        public UsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
           ILogger<UsersController> logger, IEmailSender emailSender, IConfiguration configuration) : base(context, configuration)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _logger = logger;
        }

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

        public async Task<IActionResult> Details(string id)
        {
            ApplicationUser user = await _unit.Users.GetAsync(id);

            return View(user.ToDetailsVM());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ApplicationUserCreateVM model = new ApplicationUserCreateVM
            {
                Roles = new SelectList((await _unit.Roles.GetAsync(x => x.Name != Roles.User))
                                                         .Select(x => x.CreateMaster()), "Id", "Name")
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ApplicationUserCreateVM model)
        {
            ApplicationUser user = model.Create();
            ApplicationRole role = await _unit.Roles.GetAsync(model.RoleId);

            PasswordGenerator passwordGenerator = new PasswordGenerator();
            string password = passwordGenerator.CreateRandomPassword();

            if (user != null && role != null)
            {

                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    var addRoleResult = await _userManager.AddToRoleAsync(user, role.Name);

                    if (addRoleResult.Succeeded)
                    {
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                        var messageContent = "";
                        messageContent += $"<p>Hello {user.FirstName},</p>";
                        messageContent += $"<p>Your new Cinema account with username {user.UserName} and password {password} was successfully created!</p>";
                        messageContent += "<p>";
                        messageContent += "<p>Your Cinema Team!</p>";

                        var message = new Message(new string[] { user.Email }, "New account notification", messageContent);
                        await _emailSender.SendEmailAsync(message);
                    }
                }
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            SelectList roles = new SelectList((await _unit.Roles.GetAsync(x => x.Name != Roles.User))
                                                         .Select(x => x.CreateMaster()), "Id", "Name");

            ApplicationUser user = await _unit.Users.GetAsync(id);

            return View(user.ToCreateVM(roles));
        }

        public async Task<IActionResult> Edit(ApplicationUserCreateVM model)
        {
            ApplicationUser user = await _unit.Users.GetAsync(model.Id);

            model.Update(user);

            ApplicationUserRole userRole = user.UserRoles.First();

            if (userRole.RoleId != model.RoleId)
            {
                await _userManager.RemoveFromRoleAsync(user, userRole.Role.Name);

                ApplicationRole newRole = await _unit.Roles.GetAsync(model.RoleId);
                await _userManager.AddToRoleAsync(user, newRole.Name);
            }

            await _unit.SaveAsync();

            return RedirectToAction(nameof(Details), new { id = user.Id });
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _unit.Users.DeleteAsync(id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}