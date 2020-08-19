using System;
using Cinema.Shared.Enums;

namespace Cinema.Models.Requests.Reservations
{
    public class ReservationSearchRequest : BaseSearchRequest
    {
        public int? ReservationId { get; set; }
        public int? CustomerId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ReservationStatus? Status { get; set; }
    }
}
