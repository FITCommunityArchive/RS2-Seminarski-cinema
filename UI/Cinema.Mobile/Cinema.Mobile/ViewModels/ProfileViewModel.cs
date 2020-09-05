using Cinema.Mobile.Services;
using Cinema.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class ProfileViewModel :BaseViewModel
    {

        protected readonly ApiService _usersApi = new ApiService("Users");
        public ProfileViewModel()
        {
            SaveCommand = new Command(async () => await SaveChanges());
            InitCommand = new Command(async () => await Init());
        }

        public ICommand SaveCommand { get; set; }
        public ICommand InitCommand { get; set; }
        public ApplicationUserDto CurrentUser { get; set; }

        public async Task Init()
        {
            var userId = _usersApi.GetCurrentUserId();
            CurrentUser = await _usersApi.GetById<ApplicationUserDto>(userId);
        }

        public async Task SaveChanges()
        {

        }
    }
}
