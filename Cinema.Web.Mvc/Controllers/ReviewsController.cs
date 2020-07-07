using Cinema.Authorization.Constants;
using Cinema.Authorization.Requirements;
using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Dto;
using Cinema.Dto.ViewModels.Reviews;
using Cinema.Utilities.Factory;
using Cinema.Utilities.Factory.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.Controllers
{
    [Authorize]
    public class ReviewsController : BaseController
    {
        private readonly IAuthorizationService _authorizationService;
        public ReviewsController(CinemaDbContext context, IAuthorizationService authorizationService, IConfiguration configuration) : base(context, configuration)
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

        [Authorize(Roles = Roles.User + "," + Roles.Administrator)]
        public async Task<IActionResult> SetRating(ReviewIndexVM reviewModel)
        {
            Review oldReview = await _unit.Reviews.GetAsync(reviewModel.ReviewId);
            Review review = reviewModel.Create();

            if (oldReview == null)
            {
                await _unit.Reviews.InsertAsync(review);
            }
            else
            {
                var authorizationResult = await _authorizationService.AuthorizeAsync(User, review, OperationRequirements.Update);

                if (authorizationResult.Succeeded)
                {
                    await _unit.Reviews.UpdateAsync(review, reviewModel.ReviewId);
                }
            }

            await _unit.SaveAsync();

            // This is in order to set the model with the new Id value
            //review = await _unit.Reviews.GetAsync(review.Id);
            reviewModel = new ReviewIndexVM
            {
                ReviewId = review.Id,
                Movie = new MasterModel { Id = review.MovieId },
                User = new IdentityMasterModel { Id = review.UserId },
                Rating = review.Rating
            };

            return ViewComponent("Review", reviewModel);
        }

    }
}