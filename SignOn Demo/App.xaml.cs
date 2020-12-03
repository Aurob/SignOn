using SignOn_Demo.Services;
using SignOn_Demo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignOn_Demo
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
