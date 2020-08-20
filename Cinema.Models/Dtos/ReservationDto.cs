using Cinema.Shared.Enums;
using System;

namespace Cinema.Models.Dtos
{
    public class ReservationDto : BaseDto
    {
        public bool IsCancelled { get; set; }
        public string ReservationCode { get; set; }
        public int TicketQuantity { get; set; }
        public DateTime CreatedAt { get; set; }

        public string UserId { get; set; }
        public ApplicationUserDto User { get; set; }

        public int ScreeningId { get; set; }
        public ScreeningDto Screening { get; set; }

        public int? InvoiceId { get; set; }
        public InvoiceDto Invoice { get; set; }

        public ReservationStatus Status { get; set; }
    }
}