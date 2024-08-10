using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Loggin_Basico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Corrected instantiation of MainPage
            MainPage = new NavigationPage(new MainPage());
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
