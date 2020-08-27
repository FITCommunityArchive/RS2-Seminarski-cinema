using Cinema.Mobile.Services;
using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowShowingMoviesPage : ContentPage
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");
        NowShowingMoviesViewModel model = null;

        public NowShowingMoviesPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await LoadMovies();

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

            List<MovieDto> movies = await LoadMovies();
            int moviesCount = movies.Count;
            int numberOfRows = (int)Math.Ceiling(moviesCount / 2.0);

            int numberOfColumns = 2;
            if (moviesCount == 1)
            {
                numberOfColumns = 1;
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }

            int screeningIndex = 0;


            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    var movie = movies[screeningIndex++];
                    var stream = new MemoryStream(movie.Poster);

                    ImageButton image = new ImageButton
                    {
                        BindingContext = movie,
                        Source = ImageSource.FromStream(() => stream),
                        HeightRequest = 300,
                        Command = new Command(async () => await OpenDetails(movie))
                    };

                    grid.Children.Add(image, j, i);
                }
            }

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = grid;

            BindingContext = model = new NowShowingMoviesViewModel(movies);
            await model.Init();
        }

        private async Task OpenDetails(MovieDto movie)
        {
            await Navigation.PushAsync(new MovieDetailPage(movie));
        }

        private async Task<List<MovieDto>> LoadMovies()
        {
            string route = "now-showing";
            var list = await _moviesApi.Get<List<MovieDto>>(null, route);

            return list;
        }
    }
}