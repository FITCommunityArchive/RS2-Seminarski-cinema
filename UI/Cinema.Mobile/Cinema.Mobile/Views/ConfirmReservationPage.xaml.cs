using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using Cinema.Models.SpecificModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmReservationPage : ContentPage
    {
        ConfirmReservationViewModel model = null;

        public ConfirmReservationPage(NewReservationViewModel newReservationViewModel)
        {
            InitializeComponent();
            BindingContext = model = new ConfirmReservationViewModel { NewReservation = newReservationViewModel };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void OnButtonClicked(object sender, EventArgs args)
        {
            var result = model.CheckoutReservation();

            if (result != null)
            {
                await Navigation.PushAsync(new ThankYouPage());
            }
            else
            {
                this.Content = new Label
                {
                    Text = "We were unable to process your reservation."
                };
            }           
        }
    }
}