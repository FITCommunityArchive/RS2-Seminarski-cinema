using Cinema.Mobile.Services;
using Cinema.Mobile.Views;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly ApiService _usersApi = new ApiService("Users");
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
            var roleId = -3;
            UserUpsertRequest user = new UserUpsertRequest();

            try
            {
                user.UserName = Username;
                user.Email = Email;
                user.Password = Password;
                user.FirstName = FirstName;
                user.LastName = LastName;
                user.RoleId = roleId;

                var result = await _usersApi.Insert<UserUpsertRequest>(user);

                if (result != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "Registered sucessufully", "OK");
                    Application.Current.MainPage = new MainPage();
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
