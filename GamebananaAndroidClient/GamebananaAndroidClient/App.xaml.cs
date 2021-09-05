using Gamebanana_Android_Client.Services;
using Gamebanana_Android_Client.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gamebanana_Android_Client
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
