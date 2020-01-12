using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinema.DAL.Data;
using Cinema.BLL;
using System.Security.Claims;

namespace Cinema.Web.Pages.ReservationTickets
{
    public class IndexModel : CinemaPageModel
    {
        private SeatingService _seatingService;
        private PricingService _pricingService;

        public IndexModel(Cinema.DAL.Data.ApplicationDbContext context) : base(context)
        {
            _seatingService = new SeatingService(unit);
            _pricingService = new PricingService(unit);
        }

        public Hall CurrentHall { get; set; }
        public Screening CurrentScreening { get; set; }
        public List<SeatingModel> ScreeningSeats { get; set; }
        public string ReservedSeats { get; set; }
        public Pricing PricingTier { get; set; }
        public List<int> SelectedSeats { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, long date)
        {
            var screeningDate = new DateTime(date);
            CurrentHall = await unit.Halls.GetAsync(id);

            CurrentScreening = CurrentHall.Screenings.FirstOrDefault(x => x.DateAndTime == screeningDate);

            //CurrentScreening = _context.Halls.FirstOrDefault(x => x.Id == id).Screenings
                //.FirstOrDefault(x => x.DateAndTime == ScreeningDate);

            ScreeningSeats = _seatingService.GetScreeningSeating(CurrentScreening);

            ReservedSeats = string.Join(",", _seatingService.ReservedSeats);
            PricingTier = _pricingService.GetPricingTier("Premiere");


            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(SelectedSeats == null)
            {
                return Page();
            }

            Reservation reservation = new Reservation
            {
                User = unit.Users.Get(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                Screening = CurrentScreening
            };

            unit.Reservations.Insert(reservation);

            await unit.SaveAsync();

            foreach(int seatId in SelectedSeats)
            {
                SeatReservation seatReservation = new SeatReservation
                {
                    Seat = unit.Seats.Get(seatId),
                    Reservation = reservation
                };

                unit.SeatReservations.Insert(seatReservation);
            }

            await unit.SaveAsync();
            
            return RedirectToPage("./Index");
        }
    }
}