using Cinema_JESB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_JESB.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FuncionesPage : ContentPage
	{
        
        public FuncionesPage (Cartelera cartelera)
		{
            InitializeComponent();
            BindingContext = cartelera;
		}

       
    }
}