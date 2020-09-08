using Cinema.Mobile.Services;
using Cinema.Mobile.Views;
using Cinema.Models.Requests.Users;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly ApiService _usersApi = new ApiService("Users/register");
        public RegisterViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
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

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }
        public ICommand RegisterCommand { get; set; }

        private async Task Register()
        {
            IsBusy = true;
            UserRegisterRequest user = new UserRegisterRequest();

            try
            {
                user.UserName = Username;
                user.Email = Email;
                user.Password = Password;
                user.FirstName = FirstName;
                user.LastName = LastName;

                var result = await _usersApi.Register<UserRegisterRequest>(user);

                if (result != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "Registered sucessufully", "OK");
                    ApiService.Username = result.UserName;
                    ApiService.Password = Password;

                    var loggedIn = await _usersApi.AuthUser();

                    if (loggedIn)
                    {
                        Application.Current.MainPage = new MainPage();
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Info", "We coudln't log you in. Please try later.", "OK");

                    }
                }

            }
            catch (Exception ex)
            {
                IsBusy = false;
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
