using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Pages.ReservationTickets
{
    public class IndexModel : PageModel
    {

        private readonly Cinema.Web.Data.ApplicationDbContext _context;

        public IndexModel(Cinema.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Hall CurrentHall { get; set; }
        public DateTime ScreeningDate { get; set; }
        public Screening CurrentScreening { get; set; }
        public List<Reservation> ScreeningReservations { get; set; }
        public List<SeatReservation> SeatReservationsList { get; set; }

        public List<int> ReservedSeatNumbers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, long date)
        {

            if (id == null)
            {
                return NotFound();
            }

            ScreeningDate = new DateTime(date);
            CurrentHall = await _context.Halls
                .FirstOrDefaultAsync(x => x.Id == id);

            //CurrentScreening = CurrentHall.Screenings.FirstOrDefault(x => x.DateAndTime == ScreeningDate);

            CurrentScreening = _context.Halls.FirstOrDefault(x => x.Id == id).Screenings
                .FirstOrDefault(x => x.DateAndTime == ScreeningDate);

            //ReservedSeatNumbers = GetSeatNumbers();


            return Page();
        }
    }
}