using Cinema.Shared.Enums;
using System;

namespace Cinema.Models.Requests.Reservations
{
    public class ReservationSearchRequest : BaseSearchRequest
    {
        public int? ReservationId { get; set; }
        public string CustomerFullName { get; set; }
        public string Movie { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ReservationStatus? Status { get; set; }
    }
}
