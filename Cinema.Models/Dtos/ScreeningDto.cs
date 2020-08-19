using Cinema.Shared.Enums;
using System;

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

        public TimingStatus TimingStatus { get; set; }
    }
}
