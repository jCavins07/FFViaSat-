using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace Viasat_App
{
    public partial class ResultsPage : ContentPage
    {

        public ObservableCollection<ItemModel> ItemList { get; set; }


        public ResultsPage()
        {
            InitializeComponent();
            PopulateList();
        }

        //START: BUTTONS EVENTS #######################################################

        private async void itemEntry_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        //END: BUTTONS EVENTS #########################################################





        //START: DEMONSTRATION PURPOSES  ##############################################

        private void PopulateList()//Populate a list with hardcoded elements
        {
            ItemList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {
                    ItemTitle = "Title1",
                    ItemDescription = "Description1",
                    ItemSerial = "1234564-565y24531-243561"
                },

                new ItemModel()
                {
                    ItemTitle = "Title2",
                    ItemDescription = "Description2",
                    ItemSerial = "123412-ACVBNGTS-F222"
                },

                new ItemModel()
                {
                    ItemTitle = "Title3",
                    ItemDescription = "Description3",
                    ItemSerial = "1234123-453-212-12222222"
                }
            };

            ResultsListView.ItemsSource = ItemList;
        }

    }
}
