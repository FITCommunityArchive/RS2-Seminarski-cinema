﻿using Cinema.Mobile.Models;
using Cinema.Mobile.Services;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Cinema.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.NowShowing, Title="Now Showing" },
                new HomeMenuItem {Id = MenuItemType.MyReservations, Title="My Reservations" },
                new HomeMenuItem {Id = MenuItemType.Profile, Title="Profile" },
                new HomeMenuItem {Id = MenuItemType.LogOut, Title="Log out" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;

                if (id == (int)MenuItemType.LogOut)
                {
                    LogOut();
                }
                else
                {

                    await RootPage.NavigateFromMenu(id);
                }
            };
        }

        private void LogOut()
        {
            ApiService.Username = null;
            ApiService.Password = null;
            ApiService.Token = null;
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}