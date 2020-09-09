using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class MyReservationsDetailsViewModel : BaseViewModel
    {

        private readonly ApiService _screeningsApi = new ApiService("Reservations");
        public MyReservationsDetailsViewModel()
        {

            InitCommand = new Command(async () => await Init());
            CancelCommand = new Command(async () => await CancelReservation());
        }

        public ICommand InitCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public bool _btnIsEnabled = true;
        public bool BtnIsEnabled
        {
            get { return _btnIsEnabled; }
            set { SetProperty(ref _btnIsEnabled, value); }
        }
        public ReservationDto Reservation { get; set; }

        public async Task Init()
        {

            BtnIsEnabled = !Reservation.IsCancelled;
            await Task.CompletedTask;
        }

        public async Task<bool> CancelReservation()
        {

            var prompt = await App.Current.MainPage.DisplayAlert("Reservation Cancellation", "Are you sure you want to cancel your reservation for the " + Reservation.Screening.Movie.Title + "?", "Yes", "No");
            if (prompt)
            {
                var result = await _screeningsApi.UpdateWithRoute<bool>(Reservation.Id, null, "status");
                if (result)
                {
                    BtnIsEnabled = false;
                    return true;
                }
            }
            return false;
        }
    }
}
