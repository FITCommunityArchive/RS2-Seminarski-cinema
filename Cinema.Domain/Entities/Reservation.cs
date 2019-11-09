using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Domain.Entities
{
    public class Reservation : BaseClass
    {
        public Reservation()
        {
            SeatReservations = new List<SeatReservation>();
        }       
        
        public virtual User User { get; set; }
        public virtual Screening Screening { get; set; }
        public virtual IList<SeatReservation> SeatReservations { get; set; }
    }
}