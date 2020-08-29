using System.Collections.Generic;

namespace Cinema.Models.Dtos
{
    public class MovieDto : BaseDto
    {
        public MovieDto()
        {
            GenreMovies = new List<GenreMovieDto>();
        }

        public string Title { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Synopsis { get; set; }
        public byte[] Poster { get; set; }
        public string VideoLink { get; set; }
        public string Directors { get; set; }
        public string Writers { get; set; }
        public string Actors { get; set; }
        public ICollection<GenreMovieDto> GenreMovies { get; set; }
    }
}
