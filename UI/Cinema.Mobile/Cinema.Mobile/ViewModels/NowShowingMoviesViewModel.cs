using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

        }

        public NowShowingMoviesViewModel(IEnumerable<MovieDto> movies)
        {
            foreach (var movie in movies)
            {
                MoviesList.Add(movie);
            }

            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<MovieDto> MoviesList { get; set; } = new ObservableCollection<MovieDto>();
                
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            string route = "now-showing";
            var list = await _moviesApi.Get<List<MovieDto>>(null, route);
        }   
    }       
}
