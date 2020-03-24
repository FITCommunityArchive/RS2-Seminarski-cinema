using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cinema.Authorization.Constants;
using Cinema.Authorization.Requirements;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Reviews;
using Cinema.Services.Factory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    public class ReviewsController : BaseController
    {
        private readonly IAuthorizationService _authorizationService;
        public ReviewsController(ApplicationDbContext context, IAuthorizationService authorizationService) : base(context) 
        {
            _authorizationService = authorizationService;
        }

        [HttpGet]
        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> Index()
        {
            List<ReviewIndexVM> reviews = await _unit.Reviews.Get().Select(x => x.ToIndexVM()).ToListAsync();
            return View(reviews);
        }

        [HttpGet]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Details(int reviewId)
        {
            Review review = await _unit.Reviews.GetAsync(reviewId);
            
            var authorizationResult = await _authorizationService.AuthorizeAsync(User, review, OperationRequirements.Update);
            
            if (authorizationResult.Succeeded)
            {
                return PartialView(review.ToIndexVM());
            }
            else if (User.Identity.IsAuthenticated)
            {
                return new ForbidResult();
            }
            else
            {
                return new ChallengeResult();
            }
        }

        [HttpGet]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Create(int movieId)
        {
            Movie movie = await _unit.Movies.GetAsync(movieId);
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (movie == null)
            {
                return RedirectToAction(nameof(HomeController.Error), nameof(HomeController));
            }

            Review existingReview = movie.Reviews.FirstOrDefault(x => x.UserId == userId);

            if (existingReview != null)
            {
                return RedirectToAction(nameof(ReviewsController.Edit), new { reviewId = existingReview.Id });
            }
            else
            {
                ReviewCreateVM model = new ReviewCreateVM
                {
                    Movie = movie.CreateMaster(),
                    UserId = userId,
                    Rating = 1
                };
                return PartialView(model);
            }
        }

        [HttpPost]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Create(ReviewIndexVM model)
        {
            Review review = model.Create();

            await _unit.Reviews.InsertAsync(review);
            await _unit.SaveAsync();

            return ViewComponent("Review");
            //return RedirectToAction("Details", "NowShowing", new { id = review.MovieId });
        }

        [HttpGet]
        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Edit(int reviewId)
        {

            Review review = await _unit.Reviews.GetAsync(reviewId);

            var authorizationResult = await _authorizationService.AuthorizeAsync(User, review, OperationRequirements.Update);

            if (authorizationResult.Succeeded)
            {
                ReviewUpdateVM model = review.ToUpdateVM();
                return PartialView(model);
            }
            else if (User.Identity.IsAuthenticated)
            {
                return new ForbidResult();
            }
            else
            {
                return new ChallengeResult();
            }           
        }

        [Authorize(Roles = Roles.User)]
        public async Task<IActionResult> Edit(ReviewIndexVM model)
        {
            Review review = model.Create();
            var authorizationResult = await _authorizationService.AuthorizeAsync(User, review, OperationRequirements.Update);

            if (authorizationResult.Succeeded)
            {
                await _unit.Reviews.UpdateAsync(review, model.ReviewId);
                await _unit.SaveAsync();

                return ViewComponent("Review");
                //return Redirect("/Reviews/Details?reviewId=" + review.Id); //(nameof(Details), new { reviewId = review.Id });
            }
            else if (User.Identity.IsAuthenticated)
            {
                return new ForbidResult();
            }
            else
            {
                return new ChallengeResult();
            }
        }

    }
}