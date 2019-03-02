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

        //END: BUTTONS EVENTS #########################################################


        /* SEARCHING ALGORITHM
         * 1: User enters a keword(s) in the entry field and selects parameters
         * 2: Upon click event the parameters and keywords are put into an object
         * 3: The object is serialized and sent trough the network
         * 4: Application waits for a response
         * 5: Once response data is received it is deserialized
         * 6: Deserialized data is parsed
         * 7: IF
         *      -Objects: data is put into objects and these into an ObservableCollection (list)
         *      -Error/Empty/Not found: [DEFINE HANDLING ACTION]
         * 8: Object is passed to the next page -> ResultsPage
         */        
    }
}
    