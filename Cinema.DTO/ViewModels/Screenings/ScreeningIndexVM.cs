using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DTO.ViewModels.Screenings
{
    public class ScreeningIndexVM
    {
        public int Id { get; set; }
        public string Movie { get; set; }
        public string Hall { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
