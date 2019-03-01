using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace Viasat_App
{
    public partial class ResultsPage : ContentPage
    {

        public ObservableCollection<ItemModel> ItemList { get; set; }
        public ItemModel itemToSend;


        public ResultsPage()
        {
            InitializeComponent();
            PopulateList();
        }

        //START: BUTTONS EVENTS #######################################################

        private async void itemEntry_Tapped(object sender, ItemTappedEventArgs e)
        {
            //Creating an object of type ItemModel 
            ItemModel item = (ItemModel)((ListView)sender).SelectedItem;
            ((ListView)sender).SelectedItem = null;

            //calling the ItemPage into the stack and passing the selected item by the user
            await Navigation.PushAsync(new ItemPage(item));
        }

        //END: BUTTONS EVENTS #########################################################





        //START: DEMONSTRATION PURPOSES  ##############################################

        private void PopulateList()//Populate a list with hardcoded elements
        {
            ItemList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {
                    ItemNumber = "234567845",
                    ItemDescription = "Description1",
                    ItemPartType = "PWA",
                    ItemRevision = 9
                },

                new ItemModel()
                {
                    ItemNumber = "3456765445",
                    ItemDescription = "Description2",
                    ItemPartType = "NUT",
                    ItemRevision = 5
                },

                new ItemModel()
                {
                    ItemNumber = "634567845",
                    ItemDescription = "Description3",
                    ItemPartType = "CHASSIS",
                    ItemRevision = 2
                }
            };

            ResultsListView.ItemsSource = ItemList;
        }

    }
}
