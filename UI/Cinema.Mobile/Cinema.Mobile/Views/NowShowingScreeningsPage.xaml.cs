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
    }
}