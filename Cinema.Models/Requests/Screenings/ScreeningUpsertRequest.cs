using System;

namespace Cinema.Models.Requests.Screenings
{
    public class ScreeningUpsertRequest
    {
        public DateTime DateAndTime { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public int PricingId { get; set; }
    }
}
