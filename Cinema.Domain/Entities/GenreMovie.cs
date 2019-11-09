using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class GenreMovie : BaseClass
    {
        public virtual Movie Movie { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
