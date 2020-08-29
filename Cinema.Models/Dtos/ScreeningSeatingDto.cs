using Cinema.Models.SpecificModels;
using System.Collections.Generic;

namespace Cinema.Models.Dtos
{
    public class ScreeningSeatingDto
    {
        public ScreeningSeatingDto()
        {
            Seats = new List<SeatingModel>();
        }

        public ScreeningDto Screening { get; set; }
        public ICollection<SeatingModel> Seats { get; set; }
    }
}
