using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class MyReservationsViewModel : BaseViewModel
    {
        private readonly ApiService _usersApi = new ApiService("Users");

        public MyReservationsViewModel()
        {
            //MessagingCenter.Subscribe<MyReservationsDetailsPage>(this, "refresh", (sender) =>
            //{
            //    App.Current.MainPage.DisplayAlert("Titl", "Posla brat ipak.", "Ok");
            //});
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public bool NoItems { get; set; } = false;

        public ObservableCollection<ReservationDto> _userReservations = new ObservableCollection<ReservationDto>();
        public ObservableCollection<ReservationDto> UserReservations { get { return _userReservations; } }

        public async Task Init()
        {
            var userId = await _usersApi.GetCurrentUserId();
            var reservations = await _usersApi.GetById<List<ReservationDto>>(userId, "reservations");
            if (reservations.Count == 0)
            {
                NoItems = true;
            }
            else
            {
                //after each navigateBack button from the Reservations Details we need to clear the observableCollection since it will contain the existing data and populate it with the new (same) one again.
                UserReservations.Clear();
                foreach (ReservationDto r in reservations)
                {
                    UserReservations.Add(r);
                }
            }
        }
    }
}
