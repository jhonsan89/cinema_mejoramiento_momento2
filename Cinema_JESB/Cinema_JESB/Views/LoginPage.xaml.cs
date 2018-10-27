using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_JESB.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            LoginBotton.Clicked += LoginBotton_Clicked;

        }

        private async void LoginBotton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(User.Text))
            {
                await DisplayAlert("Error", "Iingresar un usuario", "aceptar");
                User.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Error", "Ingresar una contraseña", "aceptar");
                User.Focus();
                return;
            }

            LoginActivity.IsRunning = true;
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri(https://misapis.azurewebsites.net);
            string url = string.Format("/api/Seguridad");
        }
    }
}