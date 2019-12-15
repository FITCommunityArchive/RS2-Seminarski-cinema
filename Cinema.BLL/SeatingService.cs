using Cinema.Domain.Entities;
using Cinema.DTO;
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
        public List<SeatingModel> GetScreeningSeating(int screeningId)
        {
            Screening screening = _context.Screenings.Find(screeningId);

            List<SeatingModel> reservedSeats = screening.Reservations.SelectMany(x => x.SeatReservations).ToList()
                                                             .Select(x => x.Seat.CreateSeating(true)).ToList();

            List<Seat> hallSeats = screening.Hall.Seats.ToList();

            foreach(Seat seat in hallSeats)
            {
                if(reservedSeats.FirstOrDefault(x => x.Seat.Id == seat.Id) == null)
                {
                    reservedSeats.Add(seat.CreateSeating(false));
                }
            }

            return reservedSeats.OrderBy(x => x.Seat.Id).ToList();
        }
    }
}
