using System;

namespace Cinema.Domain.Entities
{
    public class News : Post
    {
        public int TypeId { get; set; }
        public virtual NewsType Type { get; set; }
    }
}