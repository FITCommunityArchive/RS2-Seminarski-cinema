using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class Pricing : BaseType
    {
        public Pricing()
        {
            Invoices = new List<Invoice>();
        }
        public decimal Price { get; set; }
        public virtual IList<Invoice> Invoices { get; set; }
    }
}