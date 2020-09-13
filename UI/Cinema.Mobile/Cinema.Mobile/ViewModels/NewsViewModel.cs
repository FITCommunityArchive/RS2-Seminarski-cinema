using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.News;
using Cinema.Shared.Pagination;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class NewsViewModel :BaseViewModel
    {

        private readonly ApiService _newsApi = new ApiService("News");

        public NewsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public bool NoItems { get; set; } = false;

        public ObservableCollection<NewsDto> _news = new ObservableCollection<NewsDto>();
        public ObservableCollection<NewsDto> News { get { return _news; } }

        public async Task Init()
        {
            NewsSearchRequest searchRequest = new NewsSearchRequest();
            var news = await _newsApi.Get<PagedList<NewsDto>>(searchRequest, null);
            if (news.Data.Count == 0)
            {
                NoItems = true;
            }
            else
            {
                //after each navigateBack button from the Reservations Details we need to clear the observableCollection since it will contain the existing data and populate it with the new (same) one again.
                News.Clear();
                foreach (NewsDto r in news.Data)
                {
                    News.Add(r);
                }
            }
        }
    }
}
