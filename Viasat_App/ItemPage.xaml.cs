using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Viasat_App
{
    public partial class ItemPage : ContentPage
    {
        public ItemPage()
        {
            InitializeComponent();
        }

        //START: BUTTONS EVENTS #######################################################

        private async void componentsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComponentsPage());
        }

        private async void commentsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommentsPage());
        }

        private async void infoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

        //END: BUTTONS EVENTS #######################################################
    }
}
