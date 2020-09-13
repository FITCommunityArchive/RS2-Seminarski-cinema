using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

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
