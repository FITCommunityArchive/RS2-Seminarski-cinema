using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;

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

        public static int GetSeatRow(this SeatingModel seat, Hall hall)
        {
            return (seat.SeatNumber - 1) / hall.NumberOfColumns;
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

        public static int GetSeatColumn(this SeatingModel seat, Hall hall)
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
    }
}
