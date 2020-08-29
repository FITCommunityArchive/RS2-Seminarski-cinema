using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewReservationPage : ContentPage
    {
        public NewReservationPage(ScreeningDto screening)
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            await LoadMovies();

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
    }
}