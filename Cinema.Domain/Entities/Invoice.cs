using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Invoice : Reservation
    {
        //should be calculated from count of SeatReservations in Reservation class
        public int TicketQuantity { get; set; }
        public virtual Pricing OfferType { get; set; }        
        public decimal Price { get; set; }        
        public decimal TaxAmount { get; set; }
    }
}
