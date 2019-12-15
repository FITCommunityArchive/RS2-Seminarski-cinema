using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services
{
    public static class CinemaUtilities
    {
        public static void CreateSeatLabel(this Seat seat)
        {
            string seatRow = ((char)((seat.OrderNumber / seat.Hall.NumberOfRows) + 65)).ToString();
            string seatNr = (seat.OrderNumber % seat.Hall.NumberOfColumns).ToString();
            seat.Label = seatRow + seatNr;
        }
    }
}
