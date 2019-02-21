using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace Viasat_App
{
    public partial class CommentsPage : ContentPage
    {

        public ObservableCollection<CommentModel> CommentList { set; get; }

        public CommentsPage()
        {
            InitializeComponent();
            populateList();
        }



        private async void commentEntry_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommentPage());
        }


        private void populateList()
        {
            CommentList = new ObservableCollection<CommentModel>()
            {
                new CommentModel()
                {
                    CommentTitle = "comment1title",
                    CommentDescription = "comment1description",
                    CommentDate = "02/19/2019",
                    CommentAuthor = "Author1"
                },

                new CommentModel()
                {
                    CommentTitle = "comment2title",
                    CommentDescription = "comment2description",
                    CommentDate = "02/19/2019",
                    CommentAuthor = "Author2"
                },

                new CommentModel()
                {
                    CommentTitle = "comment3title",
                    CommentDescription = "comment3description",
                    CommentDate = "02/19/2019",
                    CommentAuthor = "Author3"

                },
            };
            CommentsListView.ItemsSource = CommentList;
        }
    }
}
