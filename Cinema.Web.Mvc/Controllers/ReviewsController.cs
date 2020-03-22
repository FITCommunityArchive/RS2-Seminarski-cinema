using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cinema.Authorization.Constants;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Reviews;
using Cinema.Services.Factory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    public class ReviewsController : BaseController
    {
        public ReviewsController(ApplicationDbContext context) : base(context)
        {

        }

        [HttpGet]
        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> Index()
        {
            List<ReviewIndexVM> reviews = await _unit.Reviews.Get().Select(x => x.ToIndexVM()).ToListAsync();
            return View(reviews);
        }

        [HttpGet]
        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> Details(int id)
        {
            Review review = await _unit.Reviews.GetAsync(id);

            return View(review.ToIndexVM());
        }

        [HttpGet]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Create(int movieId)
        {
            Movie movie = await _unit.Movies.GetAsync(movieId);
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (movie == null)
            {
                return RedirectToAction(nameof(HomeController.Error), nameof(HomeController));
            }

            Review existingReview = movie.Reviews.FirstOrDefault(x => x.UserId == userId);


            if (existingReview != null)
            {
                ReviewCreateVM model = new ReviewCreateVM
                {
                    Rating = existingReview.Rating,
                    IsAlreadyRated = true
                };

                return View(model);
            }
            else
            {
                ReviewCreateVM model = new ReviewCreateVM
                {
                    Movie = movie.CreateMaster(),
                    UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier),
                    Rating = 1,
                    IsAlreadyRated = false
                };

                return View(model);
            }
        }

        [HttpPost]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Create(ReviewCreateVM model)
        {
            Review review = model.Create();

            await _unit.Reviews.InsertAsync(review);
            await _unit.SaveAsync();

            return View(model);
        }

    }
}