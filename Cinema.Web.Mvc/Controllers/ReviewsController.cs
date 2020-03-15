using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Authorization.Constants;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
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

    }
}