using Cinema.Mobile.ViewModels;
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
    public partial class ThankYouPage : ContentPage
    {
        ThankYouViewModel model = null;
        public ThankYouPage(string reservationCode)
        {
            InitializeComponent();
            BindingContext = model = new ThankYouViewModel { ReservationCode = reservationCode };
        }

        private async void OnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopToRootAsync();
        }
    }
}