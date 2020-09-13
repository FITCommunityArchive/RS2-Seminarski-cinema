using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cinema.Mobile.ViewModels
{
    public class ConfirmReservationViewModel : BaseViewModel
    {
        private readonly ApiService _reservationsApi = new ApiService("Reservations");

        public ConfirmReservationViewModel()
        {
        }

        public NewReservationViewModel NewReservation { get; set; }

        public ICommand InitCommand { get; private set; }

        public async Task<ReservationDto> CheckoutReservation()
        {
            if (NewReservation.Screening == null || NewReservation.SelectedSeats.Count == 0)
            {
                return null;
            }

            ReservationUpsertRequest request = new ReservationUpsertRequest
            {
                ScreeningId = NewReservation.Screening.Id,
                SelectedSeats = NewReservation.SelectedSeats?.Select(x => x.SeatingModel.Seat.Id).ToList()
            };

            var result = await _reservationsApi.Insert<ReservationDto>(request);

            return result;
        }
    }
}
