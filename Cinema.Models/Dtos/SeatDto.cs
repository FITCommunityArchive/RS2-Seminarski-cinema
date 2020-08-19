using System.Collections.Generic;

namespace Cinema.Models.Dtos
{
    public class SeatDto : BaseDto
    {
        public SeatDto()
        {
            SeatReservations = new List<SeatReservationDto>();
        }

        public int SeatNumber { get; set; }
        public string Label { get; set; }

        public int HallId { get; set; }
        public HallDto Hall { get; set; }

        public virtual IList<SeatReservationDto> SeatReservations { get; set; }
    }
}