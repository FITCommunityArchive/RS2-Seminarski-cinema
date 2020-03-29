﻿using System;
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
using Cinema.Services.Factory;
using Cinema.Services.Helpers;
using Cinema.Web.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class MoviesController : BaseController
    {
        public MoviesController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewData["DurationSortParm"] = sortOrder == "Duration" ? "duration_desc" : "Duration";
            ViewData["YearSortParm"] = sortOrder == "Year" ? "year_desc" : "Year";
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            List<MovieIndexVM> movies = new List<MovieIndexVM>();
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = await _unit.Movies.Get().Where(x => x.Title.Contains(searchString)).Select(x => x.ToIndexVM()).ToListAsync();
            } else
            {
                movies = await _unit.Movies.Get().Select(x => x.ToIndexVM()).ToListAsync();
            }
            switch (sortOrder)
            {
                case "title_desc":
                    movies = movies.OrderByDescending(s => s.Title).ToList();
                    break;
                case "Duration":
                    movies = movies.OrderBy(s => s.Duration).ToList();
                    break;
                case "duration_desc":
                    movies = movies.OrderByDescending(s => s.Duration).ToList();
                    break;
                case "Year":
                    movies = movies.OrderBy(s => s.Year).ToList();
                    break;
                case "year_desc":
                    movies = movies.OrderByDescending(s => s.Year).ToList();
                    break;
                default:
                    movies = movies.OrderBy(s => s.Title).ToList();
                    break;
            }

            //List<MovieIndexVM> movies = await _unit.Movies.Get().Select(x => x.ToIndexVM()).ToListAsync();
            int pageSize = 10;
            return View(PaginatedList<MovieIndexVM>.Create(movies.AsQueryable(), pageNumber ?? 1, pageSize));            
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);

            return View(movie.ToIndexVM());
        }

        [AllowAnonymous]
        public async Task<IActionResult> GetAverageRating(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);

            if (movie.Reviews.Count == 0)
            {
                return Ok("N/A");
            }
            else
            {
                return Ok(movie.Reviews.Average(x => x.Rating).ToString("##.00"));
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            MovieCreateVM model = new MovieCreateVM();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MovieCreateVM model)
        {

            /*if (model.ImageFile != null)
            {
                var fileName = FileHelper.GetUniqueName(model.ImageFile.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, fileName);
                model.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
                model.Image = fileName; // Set the file name
            }*/

            Movie movie = model.Create();

            await _unit.Movies.InsertAsync(movie);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Details), new { id = movie.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            
            Movie movie = await _unit.Movies.GetAsync(id);

            return View(movie.ToCreateVM());
        }

        public async Task<IActionResult> Edit(MovieCreateVM model)
        {
            Movie movie = model.Create();

            await _unit.Movies.UpdateAsync(movie, model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Details), new { id = movie.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);

            return View(movie.ToIndexVM());
        }

        public async Task<IActionResult> Delete(MovieIndexVM model)
        {
            await _unit.Movies.DeleteAsync(model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        [Route("NowShowing"), AllowAnonymous]
        public IActionResult NowShowing(int? pageNumber, string? filterDate,string currentFilter)
        {

            DateTime DateFilter = Convert.ToDateTime(filterDate);
            var dataWithDate = _unit.Screenings.Get().Where(s => s.DateAndTime.Date == DateFilter.Date);
            ViewData["CurrentFilter"] = filterDate;

            var screenings = new NowShowingIndexVM();

            if (filterDate != null)
            {
                pageNumber = 1;
                screenings.ScreeningsList = _unit.Screenings.Get().Where(s => s.DateAndTime.Date == DateFilter.Date).Select(x => new NowShowingIndexVM.Row
                {
                    MovieId = x.MovieId,
                    MovieTitle = x.Movie.Title,
                    MovieActors = x.Movie.Actors,
                    HallName = x.Hall.Name,
                    StartTime = x.DateAndTime
                }).ToList();
                
            }
            else
            {
                filterDate = currentFilter;
                screenings.ScreeningsList = _unit.Screenings.Get().Select(x => new NowShowingIndexVM.Row
                {
                    MovieId = x.MovieId,
                    MovieTitle = x.Movie.Title,
                    MovieActors = x.Movie.Actors,
                    HallName = x.Hall.Name,
                    StartTime = x.DateAndTime
                }).ToList();
                
            }
            
            int pageSize = 12;
            return View(PaginatedList<NowShowingIndexVM.Row>.Create(screenings.ScreeningsList.AsQueryable(), pageNumber ?? 1, pageSize));
        }

        [Route("NowShowing/Details/{id:int}"), AllowAnonymous]
        public async Task<ActionResult> NowShowingDetailsAsync(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var viewModel = movie.ToNowShowingIndexVM(userId);

            if (viewModel.CurrentUserReview == null)
            {
                viewModel.CurrentUserReview = new ReviewIndexVM
                {
                    ReviewId = 0,
                    Movie = movie.CreateMaster(),
                    User = new IdentityMasterModel { Id = userId },
                    Rating = 5
                };
            }

            return View(viewModel);
        }

    }
}