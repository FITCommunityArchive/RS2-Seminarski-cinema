using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class NowShowingMoviesViewModel : BaseViewModel
    {
        private readonly ApiService _moviesApi = new ApiService("Movies");

        public NowShowingMoviesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<MovieDto> MoviesList { get; set; } = new ObservableCollection<MovieDto>();

        public ObservableCollection<MovieDto> MoviesRecommendedList { get; set; } = new ObservableCollection<MovieDto>();

        public ICommand InitCommand { get; set; } 

        public async Task Init()
        {
            string route = "now-showing";
            var list = await _moviesApi.Get<List<MovieDto>>(null, route);

            MoviesList.Clear();

            foreach (var movie in list)
            {
                MoviesList.Add(movie);
            }


            var userId = await _moviesApi.GetCurrentUserId();
            var listRecommended = await _moviesApi.Get<List<MovieDto>>(userId, "recommended");

            MoviesRecommendedList.Clear();

            foreach (var movie in listRecommended)
            {
                MoviesRecommendedList.Add(movie);
            }
        }
    }
}
