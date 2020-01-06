using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Cinema.Services.Factory;
using Cinema.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.BLL
{
    public class SeatingService
    {
        protected ApplicationDbContext _context;
        public SeatingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<SeatingModel> GetScreeningSeating(Screening screening)
        {
            //Screening screening = _context.Screenings.Find(screeningId);

            //gets reserved seats first
            List<SeatingModel> screeningSeats = screening.Reservations.SelectMany(x => x.SeatReservations).ToList()
                                                             .Select(x => x.Seat.CreateSeating(true)).ToList();

            //gets all seats
            List<Seat> hallSeats = screening.Hall.Seats.ToList();

            foreach(Seat seat in hallSeats)
            {
                //adds non-reserved seats
                if(screeningSeats.FirstOrDefault(x => x.Seat.Id == seat.Id) == null)
                {
                    screeningSeats.Add(seat.CreateSeating(false));
                }
            }

            return screeningSeats.OrderBy(x => x.Seat.Id).ToList();
        }
    }
}
