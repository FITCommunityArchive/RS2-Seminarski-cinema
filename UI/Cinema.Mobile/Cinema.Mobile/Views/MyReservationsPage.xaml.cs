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
    public partial class MyReservationsPage : ContentPage
    {
        MyReservationsViewModel model = null;
        public MyReservationsPage()
        {
            InitializeComponent();
            BindingContext = model = new MyReservationsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        public async void OnListViewItemSelected(object sender, ItemTappedEventArgs e)
        {
            ReservationDto reservation = e.Item as ReservationDto;
            await Navigation.PushAsync(new MyReservationsDetailsPage(reservation));
        }
    }
}