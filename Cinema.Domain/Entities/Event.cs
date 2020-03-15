using System;

namespace Cinema.Domain.Entities
{
    public class Event : Post
    {
        public DateTime DateAndTime { get; set; }
        public string Promoter { get; set; }

        public int TypeId { get; set; }
        public virtual EventType Type { get; set; }
    }
}