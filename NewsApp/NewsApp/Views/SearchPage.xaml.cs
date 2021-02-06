using NewsApp.Models;
using NewsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }


        private async void search_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Article a = e.Item as Article;
            await Navigation.PushAsync(new ArticleDetailsPage() { BindingContext = new ArticleDetailsViewModel(a) });

        }
    }
}