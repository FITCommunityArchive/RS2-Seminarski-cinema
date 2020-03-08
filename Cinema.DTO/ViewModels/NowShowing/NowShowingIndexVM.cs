using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DTO.ViewModels.NowShowing
{
    public class NowShowingIndexVM
    {
        public List<Row> ScreeningsList { get; set; }

        public class Row
        {
            public int MovieId { get; set; }
            public string MovieTitle { get; set; }
            public string MovieActors { get; set; }
            public string HallName { get; set; }
            public DateTime StartTime { get; set; }
        }
    }
}
