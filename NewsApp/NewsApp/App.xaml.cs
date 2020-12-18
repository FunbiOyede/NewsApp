using NewsApp.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
         

            MainPage = new NavigationPage(new RootPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
