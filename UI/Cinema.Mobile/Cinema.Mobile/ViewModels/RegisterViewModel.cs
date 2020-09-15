using Cinema.Mobile.Models;
using Cinema.Mobile.Services;
using Cinema.Mobile.Validators;
using Cinema.Mobile.Views;
using Cinema.Models.Requests.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cinema.Mobile.ViewModels
{
    public class RegisterViewModel : ValidationBaseViewModel
    {
        private readonly ApiService _usersApi = new ApiService("Users/register");
        public RegisterViewModel()
        {

            Validators = new List<IValidator>()
            {
                new StringNotNullOrEmptyValidator(nameof(Username), () => Username, "Username cannot be empty"),
                new StringNotNullOrEmptyValidator(nameof(FirstName), () => FirstName, "First name cannot be empty"),
                new StringNotNullOrEmptyValidator(nameof(LastName), () => LastName, "Last name cannot be empty"),
                //new ValidatorBase(nameof(Input), InputShouldBeInterger, "Value should be a valid number"),
                new ValidatorBase(nameof(RepeatPassword), InputsShouldBeSame, "Passowrds do not match.Make sure you type in same password in both fields"),
                new RegexValidator(nameof(Password), () => Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", "The password should have at least one lower case letter, one upper case letter, one number and one special character"),
                new RegexValidator(nameof(Email), () => Email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", "Not a valid email address")
            };

            RegisterCommand = new Command(async () => await Register());
        }

        private bool InputsShouldBeSame()
            => Password == RepeatPassword;

        //private bool InputShouldBeInterger()
        //    => int.TryParse(Input, out int _);

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                SetProperty(ref _username, value);
                OnPropertyChanged();
                Validate();
                Validate(nameof(Username));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                SetProperty(ref _password, value);
                Validate();
                Validate(nameof(Password));
            }
        }

        private string _repeatPassword;
        public string RepeatPassword
        {
            get { return _repeatPassword; }
            set
            {
                SetProperty(ref _repeatPassword, value);
                Validate();
                Validate(nameof(RepeatPassword));
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                SetProperty(ref _email, value);
                OnPropertyChanged();
                Validate();
                Validate(nameof(Email));
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                SetProperty(ref _firstName, value);
                Validate();
                Validate(nameof(FirstName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                SetProperty(ref _lastName, value);
                Validate();
                Validate(nameof(LastName));
            }
        }
        public ICommand RegisterCommand { get; set; }

        private async Task Register()
        {

            ValidateAll();
            if (ErrorStateManager.HasError)
            {
                return;
            }

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
