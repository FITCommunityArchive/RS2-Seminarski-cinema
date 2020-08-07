using System.Collections.Generic;

namespace Cinema.Models.Requests.Movies
{
    public class MovieUpsertRequest
    {
        public MovieUpsertRequest()
        {
            Genres = new List<int>();
        }

        public string Title { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public byte[] Poster { get; set; }
        public string VideoLink { get; set; }
        public string Directors { get; set; }
        public string Actors { get; set; }
        public ICollection<int> Genres { get; set; }
    }
}
