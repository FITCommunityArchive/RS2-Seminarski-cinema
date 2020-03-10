using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cinema.Web.Mvc.Models;
using Cinema.DTO.ViewModels.Movies;
using Cinema.BLL;
using Cinema.DAL.Data;
using Cinema.Services.Factory;

namespace Cinema.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UnitOfWork _unit;
        private MovieService _movieService;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _unit = new UnitOfWork(context);
            _movieService = new MovieService(_unit);
        }

        public IActionResult Index()
        {
            List<MovieIndexVM> movies = _movieService.GetComingSoonMovies().Select(x => x.ToIndexVM()).ToList();
            return View(movies);
        }

        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
