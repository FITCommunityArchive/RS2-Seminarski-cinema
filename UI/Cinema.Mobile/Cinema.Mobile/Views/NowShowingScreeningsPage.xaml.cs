using Cinema.Mobile.Services;
using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Pagination;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowShowingScreeningsPage : ContentPage
    {
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private List<ScreeningDto> _screenings;
        NowShowingScreeningsViewModel model = null;

        public NowShowingScreeningsPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await LoadScreenings();

            Grid grid = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                }
            };

            int screeningsCount = _screenings.Count;
            int numberOfRows = (int)Math.Ceiling(screeningsCount / 2.0);

            for (int i = 0; i < numberOfRows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = 620 });
            }

            int screeningIndex = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var screening = _screenings[screeningIndex];
                    var stream = new MemoryStream(screening.Movie.Poster);

                    ImageButton image = new ImageButton
                    {
                        BindingContext = screening,
                        Source = ImageSource.FromStream(() => stream),
                        HeightRequest = 600,
                        Command = new Command(async () => await OpenDetails(screening))
                    };

                    grid.Children.Add(image, j, i);
                }
            }

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = grid;

            BindingContext = model = new NowShowingScreeningsViewModel(_screenings);
            await model.Init();
        }

        private async Task OpenDetails(ScreeningDto screening3)
        {
            await Navigation.PushAsync(new ScreeningDetailPage(screening3));
        }

        private async Task LoadScreenings()
        {
            ScreeningSearchRequest search = new ScreeningSearchRequest();
            search.Includes.Add("Movie");

            var list = await _screeningsApi.Get<PagedList<ScreeningDto>>(search);
            _screenings = list.Data;
        }
    }
}