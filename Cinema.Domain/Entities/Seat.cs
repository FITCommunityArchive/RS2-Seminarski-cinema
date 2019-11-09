using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class Seat : BaseClass
    {
        public Seat()
        {
            SeatReservations = new List<SeatReservation>();
        }
        public string Row { get; set; }
        public string Column { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual IList<SeatReservation> SeatReservations { get; set; }
    }
}