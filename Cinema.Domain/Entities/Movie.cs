using System.Collections.Generic;

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
        public byte[] Poster { get; set; }
        public string VideoLink { get; set; }
        public string Directors { get; set; }
        public string Actors { get; set; }
        public virtual IList<Screening> Screenings { get; set; }
        public virtual IList<GenreMovie> GenreMovies { get; set; }
        public virtual IList<Review> Reviews { get; set; }
    }
}
