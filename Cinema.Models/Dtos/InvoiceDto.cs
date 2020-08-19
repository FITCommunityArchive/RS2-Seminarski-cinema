namespace Cinema.Models.Dtos
{
    public class InvoiceDto : BaseDto
    {
        public int ReservationId { get; set; }
        public ReservationDto Reservation { get; set; }
        public int PricingId { get; set; }
        public virtual PricingDto Pricing { get; set; }
        public decimal Price { get; set; }
        public decimal TaxAmount { get; set; }
    }
}