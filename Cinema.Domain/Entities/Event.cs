using System;

namespace Cinema.Domain.Entities
{
    public class Event : Blog
    {
        public DateTime DateAndTime { get; set; }
        public string Promoter { get; set; }
        public virtual EventType Type { get; set; }
    }
}