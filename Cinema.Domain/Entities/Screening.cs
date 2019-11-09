using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Screening : BaseClass
    {
        public Screening()
        {
            Reservations = new List<Reservation>();
        }
        public DateTime DateAndTime { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
    }
}
