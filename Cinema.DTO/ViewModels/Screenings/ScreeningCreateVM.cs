using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DTO.ViewModels.Screenings
{
    public class ScreeningCreateVM
    {
        public int Id { get; set; }
        public string Movie { get; set; }
        public string Hall { get; set; }
        public DateTime DateAndTime { get; set; }

        public int MovieId { get; set; }
        public SelectList Movies { get; set; }

        public int HallId { get; set; }
        public SelectList Halls { get; set; }
    }
}
