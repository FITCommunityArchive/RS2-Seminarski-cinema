using Cinema.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmReservationPage : ContentPage
    {
        ConfirmReservationViewModel model = null;
        private readonly int _selectedSeatsRowHeight = 70;

        public ConfirmReservationPage(NewReservationViewModel newReservationViewModel)
        {
            InitializeComponent();
            BindingContext = model = new ConfirmReservationViewModel { NewReservation = newReservationViewModel };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.ConfirmReservationListView.HeightRequest = model.NewReservation.SelectedSeats.Count * _selectedSeatsRowHeight;
        }

        private async void OnButtonClicked(object sender, EventArgs args)
        {
            var result = await model.CheckoutReservation();

            if (result != null)
            {
                await Navigation.PushAsync(new ThankYouPage(result.ReservationCode));
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