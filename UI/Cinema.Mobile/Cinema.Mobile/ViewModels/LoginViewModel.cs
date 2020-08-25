using Cinema.Mobile.Services;
using Cinema.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly ApiService _usersApi = new ApiService("Users");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            try
            {
                ApiService.Username = Username;
                ApiService.Password = Password;

                var maybeLogin = await _usersApi.AuthUser();

                if (maybeLogin == true)
                {
                    Application.Current.MainPage = new MainPage();
                }
            }
            catch (Exception ex)
            {
                IsBusy = false;
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid credentials.", "OK");
            }
        }

    }
}
