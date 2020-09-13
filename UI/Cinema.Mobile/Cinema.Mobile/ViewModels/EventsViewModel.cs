using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Events;
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
    public class EventsViewModel : BaseViewModel
    {

        private readonly ApiService _eventsApi = new ApiService("Events");

        public EventsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public bool NoItems { get; set; } = false;

        public ObservableCollection<EventDto> _events = new ObservableCollection<EventDto>();
        public ObservableCollection<EventDto> Events { get { return _events; } }

        public async Task Init()
        {
            EventSearchRequest searchRequest = new EventSearchRequest();
            searchRequest.Includes.Add("Author");
            searchRequest.Includes.Add("Type");

            var events = await _eventsApi.Get<PagedList<EventDto>>(searchRequest, null);
            if (events.Data.Count == 0)
            {
                NoItems = true;
            }
            else
            {
                //after each navigateBack button from the Reservations Details we need to clear the observableCollection since it will contain the existing data and populate it with the new (same) one again.
                Events.Clear();
                foreach (EventDto r in events.Data)
                {
                    Events.Add(r);
                }
            }
        }
    }
}
