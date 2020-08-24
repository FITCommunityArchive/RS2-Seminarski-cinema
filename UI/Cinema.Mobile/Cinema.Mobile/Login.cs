using Cinema.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Cinema.Mobile
{
    public class Login : ContentPage
    {
        public Login()
        {
            StackLayout mainStack = new StackLayout();
            mainStack.Margin = 10;
            mainStack.VerticalOptions = LayoutOptions.CenterAndExpand;

            Label lblHeading = new Label()
            {
                Text = "eCinema Login",
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Entry inputUsername = new Entry()
            {
                Placeholder = "Username"
            };

            Entry inputPassword = new Entry()
            {
                IsPassword = true
            };

            Button btnLogin = new Button()
            {
                Text = "Login"
            };

            Button btnRegister = new Button()
            {
                Text = "Register"
            };

            btnLogin.Clicked += (sender, args) =>
            {
                DisplayAlert("Information", "Login success", "OK");
            };

            btnRegister.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new RegisterPage());
            };

            mainStack.Children.Add(lblHeading);
            mainStack.Children.Add(inputUsername);
            mainStack.Children.Add(inputPassword);

            StackLayout stackButtons = new StackLayout();
            stackButtons.Children.Add(btnLogin);
            stackButtons.Children.Add(btnRegister);
            stackButtons.Orientation = StackOrientation.Horizontal;
            stackButtons.HorizontalOptions = LayoutOptions.End;

            mainStack.Children.Add(stackButtons);

            Content = mainStack;
        }
    }
}