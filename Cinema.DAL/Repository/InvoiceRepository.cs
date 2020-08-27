using Cinema.Domain.Entities;
using Cinema.Utilities.Interfaces.Dal;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Dal.Repository
{
    public class InvoiceRepository : Repository<Invoice, int>, IInvoiceRepository
    {
        private readonly IConfiguration _configuration;

        public InvoiceRepository(ICinemaDbContext context) : base(context) { }

        public void SetInvoicePrice(Invoice invoice, int ticketQuantity)
        {
            decimal taxPercentage = _configuration.GetValue<decimal>("Cinema:VatTaxPercentageDecimal");

            invoice.Price = invoice.Reservation.Screening.Pricing.Price * ticketQuantity;
            invoice.TaxAmount = invoice.Price * taxPercentage;
        }

        public async Task<bool> DeleteReservationReferences(List<Reservation> reservations)
        {

            // Soft delete reservation from all Invoices found for the provided user id
            foreach (Reservation r in reservations)
            {
                var item = _context.Invoices.Where(x => x.ReservationId == r.Id).FirstOrDefault();
                if(item != null)
                {
                    await DeleteAsync(item.Id);
                }
            }
            
            return true;
        }
    }
}
