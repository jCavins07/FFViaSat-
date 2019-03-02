using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Viasat_App
{
    public partial class ItemPage : ContentPage
    {
        public ItemPage(ItemModel itemReceived)
        {
            InitializeComponent();
            populatePage(itemReceived);
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


        //populating the GUI with the received item's data.
        private void populatePage(ItemModel itemReceived)
        {
            itemTitleLabel.Text = itemReceived.ItemNumber;
            itemNumberLabel.Text = itemReceived.ItemNumber;
            itemDescriptionLabel.Text = itemReceived.ItemDescription;
            itemRevisionLabel.Text = itemReceived.ItemRevision.ToString();
            itemPartTypeLabel.Text = itemReceived.ItemPartType;
        }

    }
}
