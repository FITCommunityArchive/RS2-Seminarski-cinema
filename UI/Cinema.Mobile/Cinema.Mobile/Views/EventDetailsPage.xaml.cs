using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventDetailsPage : ContentPage
    {
        public EventDetailsViewModel model = null;
        public EventDetailsPage(EventDto article)
        {
            InitializeComponent();
            BindingContext = model = new EventDetailsViewModel { Event = article };
        }
    }
}