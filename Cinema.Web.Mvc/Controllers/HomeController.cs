using Cinema.BLL;
using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.DTO.ViewModels.Home;
using Cinema.Web.Mvc.Models;
using EmailService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOfWork _unit;
        private MovieService _movieService;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IEmailSender emailSender, IConfiguration configuration)
        {
            _logger = logger;
            _unit = new UnitOfWork(context, configuration);
            _movieService = new MovieService(_unit);
            _emailSender = emailSender;
            _configuration = configuration;
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
            ViewData["SuccessMessage"] = "";
            ViewData["ErrorMessage"] = "";
            return View();
        }

        [Route("Contact")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(HomeContactVM contactModel)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("ContactSendForm", new { content = contactModel.Content, name = contactModel.Name, email = contactModel.Email });
            }
            ViewData["SuccessMessage"] = "";
            ViewData["ErrorMessage"] = "Please check below for the following errors.";

            return View(contactModel);
        }

        [Route("Contact/SendForm")]
        public async Task<IActionResult> ContactSendForm(string content, string name, string email)
        {
            ViewData["SuccessMessage"] = "Message has been sent. Thank you for your submission.";
            ViewData["ErrorMessage"] = "";
            var messageContent = "<strong>Name</strong><br />" + name + "<br /><br /><strong>Email</strong><br />" + email + "<br /><br /><strong>Content</strong><br />" + content;
            var message = new Message(new string[] { "boris.huseincehajic@gmail.com" }, "Contact form submission", messageContent, null);
            await _emailSender.SendEmailAsync(message);
            return View("Contact");
        }

        [Route("Blog")]
        public IActionResult Blog()
        {
            return View();
        }

        [Route("Subscribe")]
        public IActionResult SubscribeToNewsletter(string email)
        {

            var client = new RestClient("https://api.sendinblue.com/v3/contacts");
            var request = new RestRequest(Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("api-key", "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");
            //request.AddParameter("application/json", "{\"listIds\":[3],\"updateEnabled\":false,\"email\":\"" + email + "\",\"attributes\":{\"FIRSTNAME\":\"Boris\",\"LASTNAME\":\"Husein\"}}", ParameterType.RequestBody);
            request.AddParameter("application/json", "{\"listIds\":[3],\"updateEnabled\":false,\"email\":\"" + email + "\"}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return RedirectToAction("Index");
        }

    }
}
