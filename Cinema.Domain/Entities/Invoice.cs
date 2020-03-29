using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Invoice : BaseClass
    {
        //An Invoice is practically an extension of an reservation, only it doesn't inherit the Reservation class
        /*[ForeignKey("Reservation")]
        public int ReservationId { get; set; }*/

        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
        //should be calculated from count of SeatReservations in Reservation
        public int TicketQuantity { get; set; }
        public int OfferTypeId { get; set; }
        public virtual Pricing OfferType { get; set; }        
        public decimal Price { get; set; }        
        public decimal TaxAmount { get; set; }



    }
}
