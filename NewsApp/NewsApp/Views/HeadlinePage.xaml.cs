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

        private async void Goods_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (test)e.SelectedItem;
          await   DisplayAlert("ok", item.Description, "ol");
         }
    }
}