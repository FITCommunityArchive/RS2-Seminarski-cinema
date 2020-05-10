using Cinema.Domain.Entities;
using Cinema.DTO.SpecificModels;

namespace Cinema.Services.Factory
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
