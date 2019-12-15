using Cinema.Domain.Entities.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Domain.Entities
{
    public class Reservation : BaseClass
    {
        public Reservation()
        {
            SeatReservations = new List<SeatReservation>();
            Invoices = new List<Invoice>();
        }       
        
        public virtual ApplicationUser User { get; set; }
        public virtual Screening Screening { get; set; }
        //public virtual Invoice Invoice { get; set; }
        public virtual IList<SeatReservation> SeatReservations { get; set; }
        public virtual IList<Invoice> Invoices { get; set; }
    }
}