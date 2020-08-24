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
    public partial class NowShowingScreeningsPage : ContentPage
    {
        NowShowingScreeningsViewModel model = null;

        public NowShowingScreeningsPage()
        {
            InitializeComponent();
            BindingContext = model = new NowShowingScreeningsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ScreeningDto;

            await Navigation.PushAsync(new ScreeningDetailPage(item));
        }
    }
}