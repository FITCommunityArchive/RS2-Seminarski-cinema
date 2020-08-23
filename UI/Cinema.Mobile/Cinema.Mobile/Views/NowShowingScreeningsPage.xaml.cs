using Cinema.Mobile.Services;
using Cinema.Mobile.ViewModels;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Pagination;
using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly ApiService _screeningsApi = new ApiService("Screenings");
        private List<ScreeningDto> _screenings;
        NowShowingScreeningsViewModel model = null;

        public NowShowingScreeningsPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await LoadScreenings();            
            
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                }
            };

            int screeningsCount = _screenings.Count;
            int numberOfRows = (int)Math.Ceiling(screeningsCount / 2.0);

            for (int i = 0; i < numberOfRows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }

            var screening1 = _screenings[0];
            var screening2 = _screenings[1];

            var stream1 = new MemoryStream(screening1.Movie.Poster);
            
            grid.Children.Add(new Image
            {
                Source = ImageSource.FromStream(() => stream1)
            }, 0, 1);

            stream1 = new MemoryStream(screening2.Movie.Poster);

            grid.Children.Add(new Image
            {
                Source = ImageSource.FromStream(() => stream1)
            }, 1, 1);

            // Accomodate iPhone status bar.
            //this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = grid;

            BindingContext = model = new NowShowingScreeningsViewModel(_screenings);
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ScreeningDto;

            await Navigation.PushAsync(new ScreeningDetailPage(item));
        }

        private async Task LoadScreenings()
        {
            ScreeningSearchRequest search = new ScreeningSearchRequest();
            search.Includes.Add("Movie");

            var list = await _screeningsApi.Get<PagedList<ScreeningDto>>(search);
            _screenings = list.Data;
        }
    }
}