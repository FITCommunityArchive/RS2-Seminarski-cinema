using Cinema.Mobile.Services;
using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowShowingMoviesPage : ContentPage
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");
        private readonly ApiService _reviewsApi = new ApiService("Reviews");
        NowShowingMoviesViewModel model = null;

        public NowShowingMoviesPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            List<MovieDto> movies = await LoadMovies();
            int moviesCount = movies.Count;
            int numberOfRows = (int)Math.Ceiling(moviesCount / 2.0);
            int numberOfColumns = GetNumberOfColumns(moviesCount);

            Grid grid = SetUpGrid(numberOfRows);

            int screeningIndex = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (screeningIndex == movies.Count)
                    {
                        break;
                    }

                    var movie = movies[screeningIndex++];
                    ImageButton image = CreateImageButton(movie);

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

        private static Grid SetUpGrid(int numberOfRows)
        {
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

            for (int i = 0; i < numberOfRows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }

            return grid;
        }

        private int GetNumberOfColumns(int moviesCount)
        {
            if (moviesCount >= 2)
            {
                return 2;
            }
            else if (moviesCount == 1)
            {
                return 1;
            }

            return 0;
        }

        private ImageButton CreateImageButton(MovieDto movie)
        {
            ImageSource imageSource;

            if (movie.Poster.Count() == 0)
            {
                imageSource = ImageSource.FromFile("movieposterplaceholder.png");
            }
            else
            {
                var stream = new MemoryStream(movie.Poster);
                imageSource = ImageSource.FromStream(() => stream);
            }

            ImageButton image = new ImageButton
            {
                BindingContext = movie,
                Source = imageSource,
                HeightRequest = 300,
                Command = new Command(async () => await OpenDetails(movie))
            };

            return image;
        }

        private async Task OpenDetails(MovieDto movie)
        {

            //var reviewScore = _reviewsApi.
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