using System;
using System.Collections.Generic;
using ViewCellButtonSample.LocalData;
using ViewCellButtonSample.Models;
using ViewCellButtonSample.Pages;
using Xamarin.Forms;

namespace ViewCellButtonSample
{
    public class App : Application
    {
        public static List<UnderlyingData> ListOfUnderlyingData { get; set; } = SampleUnderlyingData.ListOfPrayerRequests;

        public App()
        {
            var mainListViewPage = new MainListViewPage();
            MainPage = new NavigationPage(mainListViewPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
