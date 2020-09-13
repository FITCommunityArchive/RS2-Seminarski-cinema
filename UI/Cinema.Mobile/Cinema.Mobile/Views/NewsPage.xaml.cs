using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {

        NewsViewModel model = null;
        public NewsPage()
        {
            InitializeComponent();
            BindingContext = model = new NewsViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        public async void OnListViewItemSelected(object sender, ItemTappedEventArgs e)
        {
            NewsDto article = e.Item as NewsDto;
            await Navigation.PushAsync(new NewsDetailsPage(article));
        }
    }
}