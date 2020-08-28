using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class MovieDetailsViewModel : BaseViewModel
    {

        private readonly ApiService _screeningsApi = new ApiService("Screenings");

        public MovieDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; private set; }
        public MovieDto Movie { get; set; }
        public ObservableCollection<ScreeningDto> ScreeningsList { get; set; } = new ObservableCollection<ScreeningDto>();

        public async Task Init()
        {
            ScreeningSearchRequest screeningSearchRequest = new ScreeningSearchRequest
            {
                MovieId = Movie.Id,
                Status = TimingStatus.SCHEDULED,
                Includes = { nameof(ScreeningDto.Hall) },
                SortColumn = nameof(ScreeningDto.DateAndTime),
                SortOrder = SortOrder.ASC
            };

            PagedList<ScreeningDto> movieScreenings = await _screeningsApi.Get<PagedList<ScreeningDto>>(screeningSearchRequest);

            ScreeningsList.Clear();

            foreach (var screening in movieScreenings.Data)
            {
                screening.DateAndTime = screening.DateAndTime.ToLocalTime();               
                ScreeningsList.Add(screening);
            }
        }
    }
}
