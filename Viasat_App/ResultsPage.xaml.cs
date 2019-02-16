using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Viasat_App
{
    public partial class ResultsPage : ContentPage
    {
        public ResultsPage()
        {
            InitializeComponent();
        }

        private async void itemButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }
    }
}
