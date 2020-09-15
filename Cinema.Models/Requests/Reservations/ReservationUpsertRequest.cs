using System.Collections.Generic;

namespace Cinema.Models.Requests.Reservations
{
    public class ReservationUpsertRequest
    {
        public int ScreeningId { get; set; }
        public ICollection<int> SelectedSeats { get; set; }
    }
}
