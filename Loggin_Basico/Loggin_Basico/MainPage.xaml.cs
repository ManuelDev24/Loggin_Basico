using System;
using Xamarin.Forms;

namespace Loggin_Basico
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnOk_Clicked(object sender, EventArgs e)
        {
            string sUsuario = txtUsuario.Text;
            string sPassword = txtPassword.Text;

            if (sUsuario == "Manuel" && sPassword == "123456")
            {
                Navigation.PushAsync(new Sistema());
            }
            else
            {
                DisplayAlert("Alert", "El Usuario o el Password son incorrectos", "OK");
            }
        }

        private async void btnNo_Clicked(object sender, EventArgs e)
        {
            // Exit the application
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
