using Cinema.Mobile.Services;
using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using Cinema.Models.SpecificModels;
using System;
using System.Collections.Generic;
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

            int moviesCount = seats.Count;
            int numberOfRows = _screening.Hall.NumberOfRows;
            int numberOfColumns = _screening.Hall.NumberOfColumns;

            ScrollView scrollView = new ScrollView
            {
                Orientation = ScrollOrientation.Both,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Grid grid = SetUpGrid(numberOfRows, numberOfColumns);

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

                    grid.Children.Add(seatButton, j, i);
                }
            }

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            scrollView.Content = grid;
            this.Content = scrollView;

            BindingContext = model = new NewReservationViewModel { Screening = _screening };

            await model.Init();
        }

        private Button CreateButton(SeatingModel seat)
        {
            Button button = new Button
            {
                BindingContext = seat,
                Text = seat.Seat.Label,
                Command = new Command(async () => await AddToCart(seat, _screening.Id))
            };

            return button;
        }

        private Task AddToCart(SeatingModel seat, int screeningId)
        {
            throw new NotImplementedException();
        }

        private Grid SetUpGrid(int numberOfRows, int numberOfColumns)
        {
            Grid grid = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            for (int i = 0; i < numberOfColumns; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }

            return grid;
        }

        public async Task<List<SeatingModel>> LoadSeating(int screeningId)
        {
            string route = "seating";
            var list = await _screeningsApi.GetById<List<SeatingModel>>(screeningId, route);

            return list;
        }
    }
}