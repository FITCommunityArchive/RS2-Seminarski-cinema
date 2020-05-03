using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;
using Cinema.Services.Factory;
using Cinema.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.BLL
{
    public class SeatingService
    {
        protected UnitOfWork _unit;
        public SeatingService(UnitOfWork unit)
        {
            _unit = unit;
        }

        public List<string> ReservedSeats { get; set; }

        public List<SeatingModel> GetScreeningSeating(Screening screening)
        {
            //gets reserved seats first
             List<SeatingModel> screeningSeats = screening.Reservations.Where(x => x.IsCancelled == false)
                                                                      .SelectMany(x => x.SeatReservations).ToList()
                                                                      .Select(x => x.Seat.CreateSeating(true)).ToList();

            //int row, col = 0;
            ReservedSeats = new List<string>();
            foreach(var i in screeningSeats)
            {
                int row = (i.SeatNumber / screening.Hall.NumberOfColumns);
                row++;
                int col = i.SeatNumber % screening.Hall.NumberOfColumns;
                if(row == 0)
                {
                    row = 1;
                }
                if (col == 0) {
                    row--;
                    col = screening.Hall.NumberOfColumns;
                }
                ReservedSeats.Add(row.ToString() + '_' + col.ToString());
            }
            
            //gets all seats
            List<Seat> hallSeats = screening.Hall.Seats.ToList();

            foreach(Seat seat in hallSeats)
            {
                //adds non-reserved seats
                if(!screeningSeats.Any(x => x.Seat.Id == seat.Id))
                {
                    screeningSeats.Add(seat.CreateSeating(false));
                }
            }

            return screeningSeats.OrderBy(x => x.Seat.Id).ToList();
        }

        public async Task<bool> AreSeatsReservedAsync(List<int> list, int screeningId)
        {
            var currentScreening = await _unit.Screenings.GetAsync(screeningId);

            var currentHall = currentScreening.Hall;            

            List<SeatingModel> screeningSeats = currentScreening.Reservations.SelectMany(x => x.SeatReservations).ToList()
                                                .Select(x => x.Seat.CreateSeating(true)).ToList();

            for (int i = 0; i < screeningSeats.Count; i++)
            {
                for(int j = 0; j < list.Count;j++)
                {
                    if (screeningSeats[i].SeatNumber == list[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public async Task<bool> IsSeatReservedAsync(int seatId, int screeningId)
        {
            var currentScreening = await _unit.Screenings.GetAsync(screeningId);
            var screeningReservations = await _unit.SeatReservations.GetAsync(x => x.Reservation.ScreeningId == screeningId);

            return screeningReservations.Any(x => x.SeatId == seatId);
        }

    }
}
