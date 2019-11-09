using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Genre : BaseType
    {
        public Genre()
        {
            GenreMovies = new List<GenreMovie>();
        }

        public virtual IList<GenreMovie> GenreMovies { get; set; }
    }
}
