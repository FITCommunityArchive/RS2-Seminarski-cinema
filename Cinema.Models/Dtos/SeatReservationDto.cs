namespace Cinema.Models.Dtos
{
    public class SeatReservationDto : BaseDto
    {
        public int SeatId { get; set; }
        public SeatDto Seat { get; set; }
    }
}