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
    public partial class NewsDetailsPage : ContentPage
    {
        public NewsDetailsViewModel model = null;
        public NewsDetailsPage(NewsDto article)
        {
            InitializeComponent();
            BindingContext = model = new NewsDetailsViewModel { Article = article };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}