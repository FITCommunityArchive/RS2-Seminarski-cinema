using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Domain.Entities
{
    public class Movie : BaseClass
    {
        public Movie()
        {
            Screenings = new List<Screening>();
            GenreMovies = new List<GenreMovie>();
            Reviews = new List<Review>();
        }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string VideoLink { get; set; }
        public string Directors { get; set; }
        public string Actors { get; set; }
        public virtual IList<Screening> Screenings { get; set; }
        public virtual IList<GenreMovie> GenreMovies { get; set; }
        public virtual IList<Review> Reviews { get; set; }
    }
}
