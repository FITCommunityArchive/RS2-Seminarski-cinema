using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Cinema.Services.Factory;
using Cinema.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Cinema.Domain;
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

        public List<string> ReservedSeats { get; set; }

        public List<SeatingModel> GetScreeningSeating(Screening screening)
        {
            //gets reserved seats first
            List<SeatingModel> screeningSeats = screening.Reservations.SelectMany(x => x.SeatReservations).ToList()
                                                .Select(x => x.Seat.CreateSeating(true)).ToList();


            //int row, col = 0;
            ReservedSeats = new List<string>();
            foreach(var i in screeningSeats)
            {
                int row = i.SeatNumber / screening.Hall.NumberOfRows;
                int col = i.SeatNumber % screening.Hall.NumberOfColumns;
                if (col == 0)
                    col = screening.Hall.NumberOfColumns;
                ReservedSeats.Add(row.ToString() + '_' + col.ToString());
            }
            
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
