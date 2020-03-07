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
            string seatRow = ((char)(seat.GetSeatRow() + 65)).ToString();
            string seatColumn = seat.GetSeatColumn().ToString();

            seat.Label = seatRow + seatColumn;
        }

        public static int GetSeatRow(this Seat seat)
        {
            return (seat.SeatNumber - 1) / seat.Hall.NumberOfColumns;
        }

        public static int GetSeatColumn(this Seat seat)
        {
            if (seat.SeatNumber % seat.Hall.NumberOfColumns == 0)
            {
                return seat.Hall.NumberOfColumns;
            }
            else
            {
                return seat.SeatNumber % seat.Hall.NumberOfColumns;
            }
        }
    }
}
