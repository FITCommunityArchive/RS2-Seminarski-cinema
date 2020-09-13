using Cinema.Models.Dtos;
using System.Windows.Input;

namespace Cinema.Mobile.ViewModels
{
    public class EventDetailsViewModel : BaseViewModel
    {
        public EventDetailsViewModel()
        {
        }

        public ICommand InitCommand { get; set; }
        public EventDto Event { get; set; }
    }
}
