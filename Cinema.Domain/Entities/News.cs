using System;

namespace Cinema.Domain.Entities
{
    public class News : Blog
    {
        //Date and time are already in the BaseClass property Created
        public virtual NewsType Type { get; set; }
    }
}