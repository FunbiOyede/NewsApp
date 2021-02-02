//using NewsAPI.Models;
using NewsApp.Models;
using NewsApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace NewsApp.ViewModels
{
   public class SearchViewModel : BaseViewModel
    {
        public ObservableCollection<Article> SearchLists { get; set; }


        private Article selectedType;
        public Article SelectedArticleType
        {
            get => selectedType;
            set
            {
                RaisePropertyChanged(nameof(SelectedArticleType));
                selectedType = value;
                if (value != null)
                {
                    Launcher.TryOpenAsync(value.url);
                }


            }
        }
        public ICommand SearchCommand { get; set; }

        private IApiServices apiServices;
        private bool loader;
        public bool Loader
        {
            get { return loader; }
            set { loader = value; RaisePropertyChanged(nameof(Loader)); }
        } 
        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set { _searchText = value; RaisePropertyChanged(nameof(SearchText)); }
        }
        public SearchViewModel(IApiServices services)
        {

            apiServices = services;
            SearchLists = new ObservableCollection<Article>();
            SearchCommand = new Command(SearchTopics);
           
        }

        private async void SearchTopics()

        { 
            Loader = true;
            var Items = await apiServices.SearchArticles(SearchText);
            foreach (var item in Items)
            {
                SearchLists.Add(item);
            }
            Loader = false;
        }
    }
}
