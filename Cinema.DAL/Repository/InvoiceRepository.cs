using Cinema.Dal.Data;
using Cinema.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Cinema.Dal.Repository
{
    public class InvoiceRepository : Repository<Invoice, int>
    {
        private readonly IConfiguration _configuration;

        public InvoiceRepository(ApplicationDbContext context, IConfiguration configuration) : base(context)
        {
            _configuration = configuration;
        }

        public void SetInvoicePrice(Invoice invoice, int ticketQuantity)
        {
            decimal taxPercentage = _configuration.GetValue<decimal>("Cinema:VatTaxPercentageDecimal");

            invoice.Price = invoice.Reservation.Screening.Pricing.Price * ticketQuantity;
            invoice.TaxAmount = invoice.Price * taxPercentage;
        }
    }
}
