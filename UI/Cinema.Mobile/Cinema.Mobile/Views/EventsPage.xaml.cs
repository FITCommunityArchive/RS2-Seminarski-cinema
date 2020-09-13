using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsPage : ContentPage
    {

        EventsViewModel model = null;
        public EventsPage()
        {
            InitializeComponent();
            BindingContext = model = new EventsViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        public async void OnListViewItemSelected(object sender, ItemTappedEventArgs e)
        {
            EventDto article = e.Item as EventDto;
            await Navigation.PushAsync(new EventDetailsPage(article));
        }
    }
}