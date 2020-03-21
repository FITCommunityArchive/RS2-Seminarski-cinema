using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DTO.ViewModels.Movies
{
    public class NowShowingDetailsVM
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Country { get; set; }
        public string Directors { get; set; }
        public int Duration { get; set; }
        public IList<GenreMovie> GenreMovies { get; set; }
        public string VideoLink { get; set; }
        public IList<Screening> Screenings { get; set; }

        public List<Row> ScreeningList { get; set; }

        public class Row
        {
            public int HallId { get; set; }
            public string HallName { get; set; }
            public DateTime Playing { get; set; }

        }
    }
}
