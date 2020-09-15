using System;

namespace Cinema.Models.Requests.Events
{
    public class EventUpsertRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Promoter { get; set; }
        public int TypeId { get; set; }
        public int AuthorId { get; set; }
    }
}
