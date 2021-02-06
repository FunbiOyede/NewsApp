using NewsApp.Models;
using NewsApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace NewsApp.ViewModels
{
   public class HeadlineViewModel : BaseViewModel
    {
        public ObservableCollection<Article> HeadLineList { get; set; }

        //private Article selectedType;
        //public Article SelectedArticleType
        //{
        //    get => selectedType;
        //    set
        //    {
        //        RaisePropertyChanged(nameof(SelectedArticleType));
        //        selectedType = value;
        //        if(value != null)
        //        {
        //            Launcher.TryOpenAsync(value.url);
        //        }
               

        //    }
        //}

        private IApiServices apiServices;
        private bool loader;
        public bool Loader
        {
            get { return loader; }
            set { loader = value; RaisePropertyChanged(nameof(Loader)); }
        }
        
       
        public HeadlineViewModel(IApiServices services)
        {
           
            apiServices = services;
            HeadLineList = new ObservableCollection<Article>();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
               
                Loader = true;

                var Items = await apiServices.GetArticles();
              
                foreach (var item in Items)
                {
                    HeadLineList.Add(item);

                }

                Loader = false;
            }
            catch (Exception ex)
            {

                await Application.Current.MainPage.DisplayAlert("Alert", ex.Message, "Cancel", "ok");
            }
            
        }

    }
}
