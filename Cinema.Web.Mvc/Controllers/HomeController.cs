using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cinema.Web.Mvc.Models;
using Cinema.DTO.ViewModels.Home;
using Cinema.BLL;
using Cinema.DAL.Data;
using Cinema.Services.Factory;
using Cinema.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Cinema.Services.Factory.ViewModels;
using EmailService;

namespace Cinema.Web.Mvc.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOfWork _unit;
        private MovieService _movieService;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IEmailSender emailSender)
        {
            _logger = logger;
            _unit = new UnitOfWork(context);
            _movieService = new MovieService(_unit);
            _emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> comingSoonMovies = await _movieService.GetComingSoonMovies(4);
            IEnumerable<Screening> NowShowingScreenings = await _movieService.GetNowShowingScreenings(6);
            var viewModel = new HomeIndexVM
            {
                Movies = comingSoonMovies,
                Screenings = NowShowingScreenings
            };
            return View(viewModel);
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

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Contact/SendForm")]
        public async Task<IActionResult> ContactSendForm(string content,string name, string email)
        {

            var messageContent = "<strong>Name</strong><br />" + name + "<br /><br /><strong>Email</strong><br />" + email + "<br /><br /><strong>Content</strong><br />" + content;
            var message = new Message(new string[] { "boris.huseincehajic@gmail.com" }, "Contact form submission", messageContent,null);
            await _emailSender.SendEmailAsync(message);
            return View("Contact");
        }

        [Route("Blog")]
        public IActionResult Blog()
        {
            return View();
        }



    }
}
