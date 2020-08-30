using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reservations;
using Cinema.Models.SpecificModels;
using Cinema.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class NewReservationViewModel : BaseViewModel
    {
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private readonly ApiService _reservationsApi = new ApiService("Reservations");

        public NewReservationViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ReserveCommand = new Command(async () => await Reserve());
        }

        private decimal _total = 0;
        public decimal Total 
        { 
            get { return _total; } 
            set
            {
                if (_total != value)
                {
                    _total = value;
                    OnPropertyChanged();                    
                }
            }
        }
        public ScreeningDto Screening { get; set; }
        public List<SeatingModel> Seats { get; set; } = new List<SeatingModel>();
        public ObservableCollection<SeatingModel> SelectedSeats { get; private set; } = new ObservableCollection<SeatingModel>();

        public ICommand InitCommand { get; private set; }
        public ICommand ReserveCommand { get; private set; }

        public async Task Init()
        {
        }


        private async Task Reserve()
        {
            if (Screening == null || SelectedSeats.Count == 0)
            {
                return;
            }

            ReservationUpsertRequest request = new ReservationUpsertRequest
            {
                ScreeningId = Screening.Id,
                SelectedSeats = SelectedSeats?.Select(x => x.Seat.Id).ToList()
            };

            var result = await _reservationsApi.Insert<ReservationDto>(request);
        }

        public void AddToCart(SeatingModel selectedSeat)
        {
            SeatingModel seatingModel = Seats.FirstOrDefault(x => x.Seat.Id == selectedSeat.Seat.Id);
            seatingModel.IsSelected = !seatingModel.IsSelected;

            SelectedSeats.Clear();

            IEnumerable<SeatingModel> selectedSeats = Seats.Where(x => x.IsSelected);            

            foreach (var seat in selectedSeats)
            {
                SelectedSeats.Add(seat);
            }

            Total = SelectedSeats.Count * Screening.Pricing.Price;
        }

        public bool GetSeatStatus(int selectedSeatId)
        {
            SeatingModel seatingModel = Seats.FirstOrDefault(x => x.Seat.Id == selectedSeatId);
            return seatingModel.IsSelected;
        }
    }
}
