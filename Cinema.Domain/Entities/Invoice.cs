namespace Cinema.Domain.Entities
{
    public class Invoice : BaseClass
    {
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
        public int TicketQuantity { get; set; }
        public int OfferTypeId { get; set; }
        public virtual Pricing OfferType { get; set; }
        public decimal Price { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
