using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class Seat : BaseClass
    {
        public Seat()
        {
            SeatReservations = new List<SeatReservation>();
        }

        //Seat row and column number can be calculated via the Hall properties when neccessary
        //public string Row { get; set; }
        //public string Column { get; set; }
        public int OrderNumber { get; set; }
        public string Label { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual IList<SeatReservation> SeatReservations { get; set; }
    }
}