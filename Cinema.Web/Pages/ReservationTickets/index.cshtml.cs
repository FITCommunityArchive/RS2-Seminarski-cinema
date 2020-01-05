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
        //public List<int> GetSeatNumbers()
        //{
        //    List<int> ReservedSeatNumbers = new List<int>();

        //    ScreeningReservations = _context.Reservations.Where(x => x.Id == CurrentScreening.Id).ToList();
        //    foreach 

        //    return ReservedSeatNumbers;
        //}

        public async Task<IActionResult> OnGetAsync(int? id, long date)
        {

            if (id == null)
            {
                return NotFound();
            }

            ScreeningDate = new DateTime(date);

            var aCurrentHall = await _context.Halls
                .Where(x => x.Id == id)
                .Where(c => c.Screenings.Any(i => i.DateAndTime == ScreeningDate))
                .Select(c => new
                {
                    c,
                    Screenings = c.Screenings.Where(i => i.DateAndTime == ScreeningDate)
                })
                .FirstOrDefaultAsync();

            //CurrentScreening = await _context.Screenings.FirstOrDefaultAsync(y => y.DateAndTime == ScreeningDate);


            //ReservedSeatNumbers = GetSeatNumbers();
            

            return Page();
        }
    }
}