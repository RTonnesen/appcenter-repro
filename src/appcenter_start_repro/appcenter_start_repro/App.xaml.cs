using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appcenter_start_repro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Console.WriteLine("1 ##############");
            AppCenter.Start(
                "ios=INSERT_IOS_APP_KEY_HERE;",
                typeof(Analytics),
                typeof(Crashes));
            Console.WriteLine("2 ##############");

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
