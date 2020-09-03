using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyReservationsDetailsPage : ContentPage
    {
        public MyReservationsDetailsViewModel model = null;

        public MyReservationsDetailsPage(ReservationDto reservation)
        {
            InitializeComponent();
            BindingContext = model = new MyReservationsDetailsViewModel { Reservation = reservation };
        }
    }
}