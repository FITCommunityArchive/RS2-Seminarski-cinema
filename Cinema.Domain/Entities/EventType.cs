using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class EventType : BaseType
    {
        public EventType()
        {
            Events = new List<Event>();
        }
        public virtual IList<Event> Events { get; set; }
    }
}