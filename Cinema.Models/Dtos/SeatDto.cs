namespace Cinema.Models.Dtos
{
    public class SeatDto : BaseDto
    {
        public int SeatNumber { get; set; }
        public string Label { get; set; }

        public int HallId { get; set; }
        public HallDto Hall { get; set; }
    }
}