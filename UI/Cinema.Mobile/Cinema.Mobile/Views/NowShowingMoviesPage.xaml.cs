using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using System;
using System.Collections.ObjectModel;
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
        NowShowingMoviesViewModel model = null;

        public NowShowingMoviesPage()
        {
            BindingContext = model = new NowShowingMoviesViewModel();
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();


            var movies = model.MoviesList;
            if (BtnRecommendedMovies.IsEnabled == false)
            {
                movies = model.MoviesRecommendedList;
            }
            SetupMoviesView(movies);
        }

        private void SetupMoviesView(ObservableCollection<MovieDto> movies)
        {
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

            this.NowShowingMoviesScrollView.Content = grid;
        }

        private static Grid SetUpGrid(int numberOfRows)
        {
            Grid grid = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                RowSpacing = 25,
                ColumnSpacing = 25,
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
                CornerRadius = 5,
                Command = new Command(async () => await OpenDetails(movie))
            };

            return image;
        }

        private async Task OpenDetails(MovieDto movie)
        {
            await Navigation.PushAsync(new MovieDetailPage(movie));
        }

        protected void NowShowing_Clicked(object sender, EventArgs e)
        {

            var movies = model.MoviesList;
            SetupMoviesView(movies);

            BtnNowShowingMovies.IsEnabled = false;
            BtnRecommendedMovies.IsEnabled = true;
        }

        protected void Recommended_Clicked(object sender, EventArgs e)
        {
            var movies = model.MoviesRecommendedList;
            SetupMoviesView(movies);

            BtnNowShowingMovies.IsEnabled = true;
            BtnRecommendedMovies.IsEnabled = false;
        }
    }
}