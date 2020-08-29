using Cinema.Models.Dtos;

namespace Cinema.Models.SpecificModels
{
    public class SeatingModel
    {
        public SeatDto Seat { get; set; }
        public bool IsReserved { get; set; }
    }
}
