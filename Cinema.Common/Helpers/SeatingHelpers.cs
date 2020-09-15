using Cinema.Domain.Entities;
using Cinema.Models.SpecificModels;

namespace Cinema.Common.Helpers
{
    public static class SeatingHelpers
    {
        public static string CreateSeatLabel(this Seat seat, Hall hall)
        {
            string seatRow = ((char)(seat.GetSeatRow(hall) + 65)).ToString();
            string seatColumn = seat.GetSeatColumn(hall).ToString();

            return seatRow + seatColumn;
        }

        public static int GetSeatRow(this Seat seat, Hall hall)
        {
            return (seat.SeatNumber - 1) / hall.NumberOfColumns;
        }

        public static int GetSeatRow(this SeatingModel seat, Hall hall)
        {
            return (seat.Seat.SeatNumber - 1) / hall.NumberOfColumns;
        }

        public static int GetSeatColumn(this Seat seat, Hall hall)
        {
            if (seat.SeatNumber % hall.NumberOfColumns == 0)
            {
                return hall.NumberOfColumns;
            }
            else
            {
                return seat.SeatNumber % hall.NumberOfColumns;
            }
        }

        public static int GetSeatColumn(this SeatingModel seat, Hall hall)
        {
            if (seat.Seat.SeatNumber % hall.NumberOfColumns == 0)
            {
                return hall.NumberOfColumns;
            }
            else
            {
                return seat.Seat.SeatNumber % hall.NumberOfColumns;
            }
        }
    }
}
