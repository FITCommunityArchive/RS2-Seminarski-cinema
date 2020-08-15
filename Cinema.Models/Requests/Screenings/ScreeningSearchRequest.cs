using Cinema.Shared.Enums;
using System;

namespace Cinema.Models.Requests.Screenings
{
    public class ScreeningSearchRequest : BaseSearchRequest
    {
        public string SearchTerm { get; set; }
        public string Hall { get; set; }
        public decimal? Price { get; set; }
        public TimingStatus? Status { get; set; }
        public DateTime? Date { get; set; }
    }
}
