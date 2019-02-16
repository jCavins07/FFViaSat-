using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Viasat_App
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        //START: BUTTONS EVENTS #######################################################

        private async void resultsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResultsPage());
        }

        //END: BUTTONS EVENTS #######################################################
    }
}
