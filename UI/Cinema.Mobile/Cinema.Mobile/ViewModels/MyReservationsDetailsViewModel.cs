using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class MyReservationsDetailsViewModel : BaseViewModel
    {
        public MyReservationsDetailsViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public ReservationDto Reservation { get; set; }

        public async Task Init()
        {

        }
    }
}
