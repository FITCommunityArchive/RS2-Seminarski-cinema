using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Authorization;
using Cinema.Authorization.Constants;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Movies;
using Cinema.Services.Factory;
using Cinema.Services.Helpers;
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

        public async Task<IActionResult> Index()
        {
            List<MovieIndexVM> movies = await _unit.Movies.Get().Select(x => x.ToIndexVM()).ToListAsync();

            return View(movies);            
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);

            return View(movie.ToIndexVM());
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
        public IActionResult NowShowing()
        {

            var screenings = new NowShowingIndexVM
            {
                ScreeningsList = _unit.Screenings.Get().Select(x => new NowShowingIndexVM.Row
                {
                    MovieId = x.MovieId,
                    MovieTitle = x.Movie.Title,
                    MovieActors = x.Movie.Actors,
                    HallName = x.Hall.Name,
                    StartTime = x.DateAndTime
                }).ToList()
            };
            return View(screenings);
        }

        [Route("NowShowing/Details/{id:int}"), AllowAnonymous]
        public async Task<ActionResult> NowShowingDetailsAsync(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);

            var viewModel = movie.ToNowShowingIndexVM();
            viewModel.ScreeningList = movie.Screenings.OrderBy(x=>x.DateAndTime).Select(x => new NowShowingDetailsVM.Row
            {
                HallName = x.Hall.Name,
                Playing = x.DateAndTime,
                HallId = x.Hall.Id
            }).ToList();

            return View(viewModel);
        }

    }
}