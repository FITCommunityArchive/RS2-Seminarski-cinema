using System;
using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class Screening : BaseClass
    {
        public Screening()
        {
            Reservations = new List<Reservation>();
        }

        public DateTime DateAndTime { get; set; }

        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public int PricingId { get; set; }
        public virtual Pricing Pricing { get; set; }

        public virtual IList<Reservation> Reservations { get; set; }
    }
}
