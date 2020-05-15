namespace Cinema.Dto.SpecificModels
{
    public class SeatingModel
    {
        public int SeatNumber { get; set; }
        public MasterModel Seat { get; set; }
        public bool Reserved { get; set; }
    }
}
