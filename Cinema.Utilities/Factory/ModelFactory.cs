using Cinema.Domain.Entities;
using Cinema.Models.SpecificModels;

namespace Cinema.Utilities.Factory
{
    public static class ModelFactory
    {
        public static SeatingModel CreateSeating(this Seat seat, bool reserved)
        {
            return new SeatingModel
            {
                SeatNumber = seat.SeatNumber,
                Seat = seat.CreateMaster(),
                Reserved = reserved
            };
        }
    }
}
