using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DTO.DomainModels
{
    public class MovieModel
    {
        public MovieModel()
        {
            Screenings = new List<MasterModel>();
            GenreMovies = new List<MasterModel>();
            Reviews = new List<MasterModel>();
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
        public virtual IList<MasterModel> Screenings { get; set; }
        public virtual IList<MasterModel> GenreMovies { get; set; }
        public virtual IList<MasterModel> Reviews { get; set; }
    }
}
