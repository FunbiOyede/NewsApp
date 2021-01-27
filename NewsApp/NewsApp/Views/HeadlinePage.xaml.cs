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
    public partial class HeadlinePage : ContentPage
    {

      
        public HeadlinePage()
        {
            InitializeComponent();
          

        }

        private async void headline_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Article a = e.Item as Article;
            await Navigation.PushAsync(new ArticleDetailsPage() {BindingContext = new ArticleDetailsViewModel(a) });
            //await Application.Current.MainPage.DisplayAlert("Alert", a.url, "Cancel", "ok");
        }
    }
}