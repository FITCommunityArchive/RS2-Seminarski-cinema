using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DTO.ViewModels.Home
{
    public class HomeIndexVM
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Screening> Screenings { get; set; }
    }
}
