using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
    public class DtoMovie : DtoBase
    {

        public string Title { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string VideoLink { get; set; }
        public string Directors { get; set; }
        public string Actors { get; set; }
    }
}
