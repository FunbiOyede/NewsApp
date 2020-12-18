using NewsApp.Models;
using NewsApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NewsApp.ViewModels
{
   public class HeadlineViewModel : BaseViewModel
    {
        public ObservableCollection<Article> HeadLineLists { get; set; }


        private bool loader;
        public bool Loader
        {
            get { return loader; }
            set { loader = value; RaisePropertyChanged(nameof(Loader)); }
        }

        public ApiServices apiServices = new ApiServices();
        public HeadlineViewModel()
        {
            HeadLineLists = new ObservableCollection<Article>();
            Loader = true;
            LoadData();
        }

        private async void LoadData()
        {

            HeadLineLists.Clear();
            var Items = await apiServices.GetArticles();
            foreach (var item in Items)
            {
                HeadLineLists.Add(item);
            }
            Loader = false;
        }

    }
}
