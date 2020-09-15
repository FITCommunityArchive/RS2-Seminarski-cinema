namespace Cinema.Models.Dtos
{
    public class InvoiceDto : BaseDto
    {
        public int PricingId { get; set; }
        public PricingDto Pricing { get; set; }
        public decimal Price { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal PriceWithTax { get { return Price + TaxAmount; } }
    }
}