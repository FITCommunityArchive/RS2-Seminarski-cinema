using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewReservationPage : ContentPage
    {
        public NewReservationPage(ScreeningDto screening)
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();       
        }
    }
}