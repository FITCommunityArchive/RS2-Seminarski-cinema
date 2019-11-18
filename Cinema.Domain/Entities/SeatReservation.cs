namespace Cinema.Domain.Entities
{
    public class SeatReservation : BaseClass
    {
        public virtual Reservation Reservation { get; set; }
        public virtual Seat Seat { get; set; }
    }
}