using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsOnGithub.Services;
using XamarinFormsOnGithub.Views;

namespace XamarinFormsOnGithub
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
