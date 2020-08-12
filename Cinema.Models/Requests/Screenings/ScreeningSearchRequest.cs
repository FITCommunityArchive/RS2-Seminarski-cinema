using System;

namespace Cinema.Models.Requests.Screenings
{
    public class ScreeningSearchRequest : BaseSearchRequest
    {
        public string SearchTerm { get; set; }
        public DateTime? Date { get; set; }
    }
}
