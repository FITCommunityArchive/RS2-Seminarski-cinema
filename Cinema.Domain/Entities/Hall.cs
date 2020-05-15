using System.Collections.Generic;

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
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public virtual IList<Seat> Seats { get; set; }
        public virtual IList<Screening> Screenings { get; set; }
    }
}
