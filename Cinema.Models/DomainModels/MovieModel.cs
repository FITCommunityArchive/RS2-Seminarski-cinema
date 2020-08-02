using Cinema.Models.Dtos;
using System.Collections.Generic;

namespace Cinema.Models.DomainModels
{
    public class MovieModel
    {
        public MovieModel()
        {
            Screenings = new List<MasterDto>();
            GenreMovies = new List<MasterDto>();
            Reviews = new List<MasterDto>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string VideoLink { get; set; }
        public string Directors { get; set; }
        public string Actors { get; set; }
        public IList<MasterDto> Screenings { get; set; }
        public IList<MasterDto> GenreMovies { get; set; }
        public IList<MasterDto> Reviews { get; set; }
    }
}
