using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class Seat : BaseClass
    {
        public Seat()
        {
            SeatReservations = new List<SeatReservation>();
        }

        public int SeatNumber { get; set; }
        public string Label { get; set; }

        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }

        public virtual IList<SeatReservation> SeatReservations { get; set; }
    }
}