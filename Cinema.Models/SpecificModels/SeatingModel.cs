using Cinema.Models.Dtos;

namespace Cinema.Models.SpecificModels
{
    public class SeatingModel
    {
        public int SeatNumber { get; set; }
        public MasterDto Seat { get; set; }
        public bool Reserved { get; set; }
    }
}
