using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;

namespace Cinema.Models.Dtos
{
    public class ScreeningDto : BaseDto
    {
        public DateTime DateAndTime { get; set; }

        public int HallId { get; set; }
        public HallDto Hall { get; set; }

        public int MovieId { get; set; }
        public MovieDto Movie { get; set; }

        public int PricingId { get; set; }
        public PricingDto Pricing { get; set; }
    }
}
