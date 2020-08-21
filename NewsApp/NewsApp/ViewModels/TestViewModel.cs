using NewsApp.Models;
using NewsApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewsApp.ViewModels
{
    public class TestViewModel
    {

        public IMockDataStore<test> DataStore => DependencyService.Get<IMockDataStore<test>>();
        public ObservableCollection<test> GoodLists { get; }
        public TestViewModel()
        {
            GoodLists = new ObservableCollection<test>();
            LoadData();

        }

        public async Task  LoadData()
        {
            try
            {
                GoodLists.Clear();
                var Items = await DataStore.GetResult();
                foreach(var item in Items)
                {
                    GoodLists.Add(item);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
              
            }

        }
    }
}
