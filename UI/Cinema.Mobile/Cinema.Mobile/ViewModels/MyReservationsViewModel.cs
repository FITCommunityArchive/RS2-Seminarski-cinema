﻿using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class MyReservationsViewModel : BaseViewModel
    {
        private readonly ApiService _usersApi = new ApiService("Users");

        public MyReservationsViewModel()
        {
            InitCommand = new Command(async() => await Init());

            MessagingCenter.Subscribe<MyReservationsDetailsViewModel>(this, "refresh", (sender) =>
             {
                 App.Current.MainPage.DisplayAlert("Titl", "Opala", "Ok");
             });
        }

        public ICommand InitCommand { get; set; }

        public ObservableCollection<ReservationDto> _userReservations = new ObservableCollection<ReservationDto>();
        public ObservableCollection<ReservationDto> UserReservations { get { return _userReservations; } }

        public async Task Init()
        {
            var userId = await _usersApi.GetCurrentUserId();
            var reservations = await _usersApi.GetById<List<ReservationDto>>(userId, "reservations");
            foreach(ReservationDto r in reservations)
            {
                UserReservations.Add(r);
            }
        }
    }
}
