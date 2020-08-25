using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailPage : ContentPage
    {
        MovieDetailsViewModel model = null;

        public MovieDetailPage(MovieDto movie)
        {
            InitializeComponent();
            BindingContext = model = new MovieDetailsViewModel() { Movie = movie };
        }
    }
}