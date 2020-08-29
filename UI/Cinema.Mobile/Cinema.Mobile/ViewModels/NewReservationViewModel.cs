using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.SpecificModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class NewReservationViewModel : BaseViewModel
    {
        private readonly ApiService _screeningsApi = new ApiService("Screenings");

        public NewReservationViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ScreeningDto Screening { get; set; }
        //public ObservableCollection<SeatingModel> SeatsList { get; set; } = new ObservableCollection<SeatingModel>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {/*
            string route = "seating";
            var list = await _screeningsApi.GetById<List<SeatingModel>>(Screening.Id, route);

            SeatsList.Clear();

            foreach (var seat in list)
            {
                SeatsList.Add(seat);
            }*/
        }
    }
}
