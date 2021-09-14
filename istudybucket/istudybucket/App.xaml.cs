using istudybucket.Services;
using istudybucket.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace istudybucket
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
