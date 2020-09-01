using Cinema.Mobile.Services;
using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using Cinema.Models.SpecificModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewReservationPage : ContentPage
    {
        NewReservationViewModel model = null;
        private readonly ScreeningDto _screening;
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private readonly int _selectedSeatsRowHeight = 50;

        public NewReservationPage(ScreeningDto screening)
        {
            InitializeComponent();
            _screening = screening;
            BindingContext = model = new NewReservationViewModel { Screening = screening };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            List<SeatingModel> seats = await LoadSeating(_screening.Id);

            BindingContext = model = new NewReservationViewModel 
            { 
                Screening = _screening,
                Seats = seats
            };

            int numberOfRows = _screening.Hall.NumberOfRows;
            int numberOfColumns = _screening.Hall.NumberOfColumns;

            SetUpGrid(numberOfRows, numberOfColumns);

            int seatIndex = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (seatIndex == seats.Count)
                    {
                        break;
                    }

                    var seat = seats[seatIndex++];
                    Button seatButton = CreateButton(seat);

                    this.NewReservationSeatingGrid.Children.Add(seatButton, j, i);
                }
            }

            this.SelectedSeatsListView.RowHeight = _selectedSeatsRowHeight;

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            model.Init();
        }

        private Button CreateButton(SeatingModel seat)
        {
            Button button = new Button
            {
                BindingContext = seat,
                Text = seat.Seat.Label,
                BackgroundColor = seat.IsReserved ? Color.Gray : Color.White,
                TextColor = seat.IsReserved ? Color.White : Color.Gray
            };

            button.Command = new Command(() => AddToCart(button, seat));
            return button;
        }

        private void AddToCart(Button button, SeatingModel seat)
        {
            model.AddToCart(seat);

            AdjustSelectedSeats(button, seat);
        }

        private void AdjustSelectedSeats(Button button, SeatingModel seat)
        {
            bool seatStatus = model.GetSeatStatus(seat.Seat.Id);
            button.TextColor = GetButtonTextColor(seatStatus);
            button.BackgroundColor = GetButtonBackgroundColor(seatStatus);

            int selectedSeatsCount = model.SelectedSeats.Count;

            this.SelectedSeatsListView.HeightRequest = selectedSeatsCount * _selectedSeatsRowHeight;
        }

        private Color GetButtonTextColor(bool seatStatus)
        {            
            if (seatStatus)
            {
                return Color.White;
            }
            else
            {
                return Color.Gray;
            }
        }

        private Color GetButtonBackgroundColor(bool seatStatus)
        {
            if (seatStatus)
            {
                return Color.Green;
            }
            else
            {
                return Color.White;
            }
        }


        private void SetUpGrid(int numberOfRows, int numberOfColumns)
        {
            for (int i = 0; i < numberOfColumns; i++)
            {
                this.NewReservationSeatingGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                this.NewReservationSeatingGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }
        }

        private async Task<List<SeatingModel>> LoadSeating(int screeningId)
        {
            string route = "seating";
            var list = await _screeningsApi.GetById<List<SeatingModel>>(screeningId, route);

            return list;
        }

        private void OnButtonClicked_CancelSeat(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as SelectedSeatViewModel;

            SeatDto seat = item.SeatingModel.Seat;
            model.RemoveFromCart(seat.Id);

            var buttons = this.NewReservationSeatingGrid.Children;

            foreach (var button in buttons)
            {
                var seatingModel = button.BindingContext as SeatingModel;

                if (seatingModel.Seat.Id == seat.Id)
                {
                    AdjustSelectedSeats(button as Button, item.SeatingModel);
                }
            }
        }

        private async void OnButtonClicked_Reserve(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConfirmReservationPage(model));
        }    
    }
}