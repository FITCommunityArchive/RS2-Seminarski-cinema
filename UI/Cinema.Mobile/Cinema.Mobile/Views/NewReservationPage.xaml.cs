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
            await model.Init();

            List<SeatingModel> seats = model.Seats;

            int numberOfRows = _screening.Hall.NumberOfRows;
            int numberOfColumns = _screening.Hall.NumberOfColumns;

            SetUpGrid(numberOfRows, numberOfColumns);

            int seatIndex = 0;

            //this.NewReservationSeatingGridLoadingLabel.HeightRequest = 0;
            this.NewReservationSeatingGridLoadingLabel.IsVisible = false;

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
        }

        private Button CreateButton(SeatingModel seat)
        {
            Button button = new Button
            {                
                BindingContext = seat,
                Text = seat.Seat.Label,
                IsEnabled = !seat.IsReserved,
                BackgroundColor = seat.IsReserved ? Color.Gray : Color.White,
                TextColor = seat.IsReserved ? Color.White : Color.Gray,
                CornerRadius = 2,
                BorderColor = Color.Gray,
                WidthRequest = 45
            };

            if (!seat.IsReserved)
            {
                button.Command = new Command(() => AddToCart(button, seat));
            }

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
                return Color.FromRgb(125, 180, 113);
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

        private void OnButtonClicked_CancelSeat(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as SelectedSeatViewModel;

            SeatDto seat = item.SeatingModel.Seat;
            model.RemoveFromCart(seat.Id);

            var buttons = this.NewReservationSeatingGrid.Children.Where(x => x is Button);

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