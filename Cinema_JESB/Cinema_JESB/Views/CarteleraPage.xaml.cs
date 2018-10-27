using Cinema_JESB.Models;
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
	public partial class CarteleraPage : ContentPage
	{
		public CarteleraPage ()
		{
			InitializeComponent ();
            CargarPeliculas();
		}
        private async void CargarPeliculas()
        {
            HttpClient cines = new HttpClient();

            cines.BaseAddress = new Uri("http://misapis.azurewebsites.net");
            var request = await cines.GetAsync("/api/Cartelera");

            if (request.IsSuccessStatusCode)
            {
                var responseJSON = await request.Content.ReadAsStringAsync();
                var respuestaCateleras = JsonConvert.DeserializeObject<List<Cartelera>>(responseJSON);
                listCarteleras.ItemsSource = respuestaCateleras;
            }


        }

        private async void PeliculaSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var cartelera = e.SelectedItem as Cartelera;
            await Navigation.PushModalAsync(new FuncionesPage(cartelera));
        }

    }
}