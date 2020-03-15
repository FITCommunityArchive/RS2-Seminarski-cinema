namespace Cinema.Domain.Entities
{
    public class SeatReservation : BaseClass
    {
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }

        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }
    }
}