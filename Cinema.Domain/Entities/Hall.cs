using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Hall : BaseClass
    {
        public Hall()
        {
            Seats = new List<Seat>();
            Screenings = new List<Screening>();
        }
        public string Name { get; set; }
        public virtual IList<Seat> Seats { get; set; }
        public virtual IList<Screening> Screenings { get; set; }
    }
}
