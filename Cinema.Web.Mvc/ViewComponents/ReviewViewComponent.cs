using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Reviews;
using Cinema.Services.Factory;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.ViewComponents
{
    public class ReviewViewComponent : ViewComponent
    {
        private UnitOfWork _unit;
        private UserManager<ApplicationUser> _userManager;
        public ReviewViewComponent(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _unit = new UnitOfWork(context);
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string methodName, int movieId, int reviewId = 0)
        {
            Movie movie = await _unit.Movies.GetAsync(movieId);
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);

            ReviewIndexVM model = new ReviewIndexVM
            {
                Id = reviewId,
                Movie = movie.CreateMaster(),
                User = user.CreateMaster(),
                Rating = 5
            };

            ViewBag.Method = methodName;

            return View(model);
        }
    }
}
