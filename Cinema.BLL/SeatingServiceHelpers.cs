using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.BLL
{
    public static class SeatingServiceHelpers
    {
        public static void CreateSeatLabel(this Seat seat)
        {
            string seatRow = ((char)(((seat.SeatNumber - 1) / seat.Hall.NumberOfRows) + 65)).ToString();

            string seatNr;

            if (seat.SeatNumber % seat.Hall.NumberOfColumns == 0)
            {
                seatNr = seat.Hall.NumberOfColumns.ToString();
            }
            else
            {
                seatNr = (seat.SeatNumber % seat.Hall.NumberOfColumns).ToString();
            }

            seat.Label = seatRow + seatNr;
        }
    }
}
