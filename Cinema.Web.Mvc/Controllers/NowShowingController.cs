using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.NowShowing;
using Cinema.Services.Factory;
using Cinema.Services.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Cinema.Web.Mvc.Controllers
{
    public class NowShowingController : BaseController
    {

        public NowShowingController(ApplicationDbContext context) : base(context) { }
        public IActionResult Index()
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

        public async Task<ActionResult> Details(int id)
        {
            Movie movie = await _unit.Movies.GetAsync(id);
            //var movie = _unit.Movies.Get(id).Select(x => new NowShowingDetailsVM
            //{
            //    Title = x.Title,
            //    Directors = x.Directors,
            //    Duration = x.Duration,
            //    Country = x.Country,
            //    Actors = x.Actors,
            //    GenreMovies = x.GenreMovies.Count,
            //    Screenings = x.Screenings,
            //    VideoLink = x.VideoLink,
            //    Year = x.Year,
            //    Id = x.Id
            //});
            return View(movie.ToNowShowingIndexVM());
        }
    }
}