using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Mvc.Areas.Identity.Pages.Account.Manage
{
    public class ReservationsModel : PageModel
    {
        protected UnitOfWork _unit;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<PersonalDataModel> _logger;

        public ReservationsModel(
            UserManager<ApplicationUser> userManager,
            ILogger<PersonalDataModel> logger,
            ApplicationDbContext context,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _logger = logger;
            _unit = new UnitOfWork(context, configuration);
        }

        public List<Reservation> UserReservations { get; set; }
        public IList<Reservation> UserReservationsList { get; set; }

        public async Task<IActionResult> OnGet()
        {

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            //UserReservations = _unit.Reservations.Get(x=>x.UserId == user.)
            UserReservationsList = user.Reservations.Where(x => x.IsCancelled == false).ToList();

            return Page();
        }
    }
}
