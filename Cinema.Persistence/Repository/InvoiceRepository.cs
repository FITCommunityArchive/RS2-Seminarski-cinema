using Cinema.Common.Interfaces.Dal;
using Cinema.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Cinema.Persistence.Repository
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
    }
}
