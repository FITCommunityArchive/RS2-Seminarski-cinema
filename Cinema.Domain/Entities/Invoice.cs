using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Invoice : Reservation
    {
        public int NumberOfTickets { get; set; }
        public virtual Pricing OfferType { get; set; }

        //should be calculated from count of SeatReservations in Reservation class
        public decimal Price { get; set; }
        public int TicketQuantity { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
