using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class Pricing : BaseType
    {
        public Pricing()
        {
            Invoices = new List<Invoice>();
            Screenings = new List<Screening>();
        }
        public decimal Price { get; set; }
        public virtual IList<Invoice> Invoices { get; set; }
        public virtual IList<Screening> Screenings { get; set; }
    }
}