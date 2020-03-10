using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Movies;
using Cinema.Services.Factory;
using Cinema.Services.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Mvc.Controllers
{
    public class MoviesController : BaseController
    {
        public MoviesController(ApplicationDbContext context) : base(context) { }

        public async Task<IActionResult> Index()
        {
            List<MovieIndexVM> movies = await _unit.Movies.Get().Select(x => x.ToIndexVM()).ToListAsync();
            return View(movies);            
        }

        public async Task<IActionResult> Details(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);

            return View(movie.ToIndexVM());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
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

            _unit.Movies.Insert(movie);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Details), new { id = movie.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);

            return View(movie.ToCreateVM());
        }

        [HttpPut]
        public async Task<IActionResult> Edit(MovieCreateVM model)
        {
            Movie movie = model.Create();

            _unit.Movies.Update(movie, model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Details), new { id = movie.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);

            return View(movie.ToIndexVM());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(MovieIndexVM model)
        {
            _unit.Movies.Delete(model.Id);
            await _unit.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}