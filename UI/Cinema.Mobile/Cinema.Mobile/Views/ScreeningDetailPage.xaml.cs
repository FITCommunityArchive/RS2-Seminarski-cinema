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
    public partial class ScreeningDetailPage : ContentPage
    {
        ScreeningDetailsViewModel model = null;

        public ScreeningDetailPage(ScreeningDto screening)
        {
            InitializeComponent();
            BindingContext = model = new ScreeningDetailsViewModel() { Screening = screening };
        }
    }
}