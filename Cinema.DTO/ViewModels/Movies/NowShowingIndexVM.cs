using System;
using System.Collections.Generic;

namespace Cinema.DTO.ViewModels.Movies
{
    public class NowShowingIndexVM
    {
        public List<Row> MoviesList { get; set; }

        public class Row
        {
            public int MovieId { get; set; }
            public string MovieTitle { get; set; }
            public string MovieActors { get; set; }
            public string HallName { get; set; }
            public DateTime StartTime { get; set; }
            public string MovieRatingDescription { get; set; }
            public int? MovieRating { get; set; }
            public int Duration { get; set; }
            public int Year { get; set; }
            public string Country { get; set; }
        }
    }
}
