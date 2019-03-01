using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Viasat_App
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        //testing purposes:
        string username = "Admin";
        string password = "1234";

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            //Testing logic
            if (usernameEntry.Text == username && passwordEntry.Text == password)
            {
                await DisplayAlert("SUCCESS", "success message", "OK");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("ON FAIL", "Username or Password were incorrect. Please try again.", "OK");
            }
        }
    }
}
