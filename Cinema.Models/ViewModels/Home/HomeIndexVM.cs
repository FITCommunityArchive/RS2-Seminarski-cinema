using Cinema.Domain.Entities;
using System.Collections.Generic;

namespace Cinema.Models.ViewModels.Home
{
    public class HomeIndexVM
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Screening> Screenings { get; set; }
    }
}
