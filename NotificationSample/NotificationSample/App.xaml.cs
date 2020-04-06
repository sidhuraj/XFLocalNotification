using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotificationSample
{
    public partial class App : Application
    {
        //Handle Push Notifications Concepts: add Below Lines upto else(and committe public app{}//
        //public App(bool shallNavigate)
        //{
        //    InitializeComponent();
        //    if (shallNavigate)
        //    {
        //        MainPage = new NavigationPage(new DashboardPage());
        //    }
        //    else
        //    {
        //        MainPage = new NavigationPage(new MainPage());
        //    }
        //}
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
