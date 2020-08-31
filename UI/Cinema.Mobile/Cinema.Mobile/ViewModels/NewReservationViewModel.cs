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
        private readonly PricingService _pricingService = new PricingService();
        public NewReservationViewModel()
        {
            InitCommand = new Command(() => Init());
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

        public string Currency { get; set; }
        public ScreeningDto Screening { get; set; }
        public List<SeatingModel> Seats { get; set; } = new List<SeatingModel>();
        public ObservableCollection<SelectedSeatViewModel> SelectedSeats { get; private set; } = new ObservableCollection<SelectedSeatViewModel>();

        public ICommand InitCommand { get; private set; }
        public ICommand ReserveCommand { get; private set; }

        public void Init()
        {
            Currency = Currencies.DEFAULT;
        }

        public void AddToCart(SeatingModel selectedSeat)
        {
            SeatingModel seatingModel = Seats.FirstOrDefault(x => x.Seat.Id == selectedSeat.Seat.Id);
            seatingModel.IsSelected = !seatingModel.IsSelected;

            SelectedSeats.Clear();

            IEnumerable<SeatingModel> selectedSeats = Seats.Where(x => x.IsSelected);

            decimal seatPriceWithVat = _pricingService.CalculateTotalWithVatAmount(Screening.Pricing.Price);

            foreach (var seat in selectedSeats)
            {
                SelectedSeatViewModel selectedSeatViewModel = new SelectedSeatViewModel
                {
                    SeatingModel = seat,
                    Description = $"{Screening.Pricing.Name} Seat {seat.Seat.Label} - {seatPriceWithVat} {Currency}"
                };

                SelectedSeats.Add(selectedSeatViewModel);
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
