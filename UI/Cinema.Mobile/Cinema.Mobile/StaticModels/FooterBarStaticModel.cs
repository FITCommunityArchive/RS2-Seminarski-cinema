using Cinema.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.StaticModels
{
    public static class FooterBarStaticModel
    {
        public static ICommand MovieBtnCommand { get; set; } = new Command(() => MovieBtn_OnClicked());
        public static ICommand NewsBtnCommand { get; set; } = new Command(() => NewsBtn_OnClicked());
        public static ICommand ProfileBtnCommand { get; set; } = new Command(() => ProfileBtn_OnClicked());

        public static void MovieBtn_OnClicked()
        {
            var masterDetailPage = (MasterDetailPage)Application.Current.MainPage;
            masterDetailPage.Detail = new NavigationPage(new NowShowingMoviesPage());
        }

        public static void NewsBtn_OnClicked()
        {
            var masterDetailPage = (MasterDetailPage)Application.Current.MainPage;
            masterDetailPage.Detail = new NavigationPage(new MyReservationsPage());
        }

        public static void ProfileBtn_OnClicked()
        {
            var masterDetailPage = (MasterDetailPage)Application.Current.MainPage;
            masterDetailPage.Detail = new NavigationPage(new ProfilePage());
        }

    }
}
