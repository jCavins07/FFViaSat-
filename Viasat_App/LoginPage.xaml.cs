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

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

            //LOGIN CODE HERE ############################################################

            //if(UsernameEnteredExistsInDB() && UsernameEntered.Password == passwordEntry.Text)
            //{
            //    //LOGIN SUCCESS
            //    //RETRIEVE SESSION DATA FROM DB
            //    //POPULATE SESSION DATA IN THE APP
            //    //NAVIGATE TO HOME PAGE
            //}
            //else
            //{
            //    //LOGIN FAILURE
            //    //PROMPT LOGIN ERROR MESSAGE
            //    //INITIALIZE SECURITY PROTOCOL?
            //}

            //############################################################################

        }
    }
}
