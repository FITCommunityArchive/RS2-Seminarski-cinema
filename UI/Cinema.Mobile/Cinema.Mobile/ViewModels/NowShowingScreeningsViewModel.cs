using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Pagination;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class NowShowingScreeningsViewModel : BaseViewModel
    {
        private readonly ApiService _screeningsApi = new ApiService("Screenings");

        public NowShowingScreeningsViewModel()
        {

        }

        public NowShowingScreeningsViewModel(List<ScreeningDto> screenings)
        {
            foreach (var screening in screenings)
            {
                ScreeningsList.Add(screening);
            }

            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<ScreeningDto> ScreeningsList { get; set; } = new ObservableCollection<ScreeningDto>();
                
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {           
            
            ScreeningSearchRequest search = new ScreeningSearchRequest();
            search.Includes.Add("Movie");
            
            var list = await _screeningsApi.Get<PagedList<ScreeningDto>>(search);

            /*
            ScreeningsList.Clear();

            foreach (var screening in list.Data)
            {
                ScreeningsList.Add(screening);
            }*/
        }   
    }       
}
