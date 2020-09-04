using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.SpecificModels;
using Cinema.Shared.Constants;
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
        private readonly PricingService _pricingService = new PricingService();
        public NewReservationViewModel()
        {
            InitCommand = new Command(async () => await Init());
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

        private decimal _vat = 0;
        public decimal Vat
        {
            get { return _vat; }
            set
            {
                if (_vat != value)
                {
                    _vat = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _totalWithVat = 0;
        public decimal TotalWithVat 
        { 
            get { return _totalWithVat; } 
            set
            {
                if (_totalWithVat != value)
                {
                    _totalWithVat = value;
                    OnPropertyChanged();                    
                }
            }
        }

        private string _currency;
        public string Currency
        {
            get { return _currency; }
            set
            {
                if (_currency != value)
                {
                    _currency = value;
                    OnPropertyChanged();
                }
            }
        }

        public ScreeningDto Screening { get; set; }
        public List<SeatingModel> Seats { get; set; } = new List<SeatingModel>();
        public ObservableCollection<SelectedSeatViewModel> SelectedSeats { get; private set; } = new ObservableCollection<SelectedSeatViewModel>();

        public ICommand InitCommand { get; private set; }
        public ICommand ReserveCommand { get; private set; }

        public async Task Init()
        {
            Currency = Currencies.DEFAULT;

            string route = "seating";
            var list = await _screeningsApi.GetById<List<SeatingModel>>(Screening.Id, route);

            Seats = list;
        }

        public void AddToCart(SeatingModel selectedSeat)
        {
            SeatingModel seatingModel = Seats.FirstOrDefault(x => x.Seat.Id == selectedSeat.Seat.Id);
            seatingModel.IsSelected = !seatingModel.IsSelected;

            SelectedSeats.Clear();

            IEnumerable<SeatingModel> selectedSeats = Seats.Where(x => x.IsSelected);

            string seatPriceWithVat = _pricingService.GetTotalWithVatAmount(Screening.Pricing.Price);

            foreach (var seat in selectedSeats)
            {
                SelectedSeatViewModel selectedSeatViewModel = new SelectedSeatViewModel
                {
                    SeatingModel = seat,
                    Description = $"{Screening.Pricing.Name} Seat {seat.Seat.Label} - {seatPriceWithVat} {Currency}"
                };

                SelectedSeats.Add(selectedSeatViewModel);
            }

            CalculateTotals();
        }

        public void RemoveFromCart(int seatId)
        {
            SelectedSeatViewModel selectedSeatViewModel = SelectedSeats.FirstOrDefault(x => x.SeatingModel.Seat.Id == seatId);
            SeatingModel seatingModel = selectedSeatViewModel.SeatingModel;
            seatingModel.IsSelected = false;

            SelectedSeats.Remove(selectedSeatViewModel);
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            Total = SelectedSeats.Count * Screening.Pricing.Price;
            Vat = _pricingService.CalculateVatAmount(Total);

            decimal totalWithVat = _pricingService.CalculateTotalWithVatAmount(Screening.Pricing.Price);
            TotalWithVat = SelectedSeats.Count * totalWithVat;
        }

        public bool GetSeatStatus(int selectedSeatId)
        {
            SeatingModel seatingModel = Seats.FirstOrDefault(x => x.Seat.Id == selectedSeatId);
            return seatingModel.IsSelected;
        }
    }
}
