
using System;

namespace Cinema.Models.Requests.Events
{
    public class EventSearchRequest : BaseSearchRequest
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int? TypeId { get; set; }
        public DateTime? DateAndTime { get; set; }
        public string Promoter { get; set; }
    }
}
