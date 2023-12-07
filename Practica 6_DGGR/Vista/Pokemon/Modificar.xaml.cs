using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_6_DGGR.Modelo;
using Practica_6_DGGR.VistaModelo.VMpokemon;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_6_DGGR.Vista.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Modificar : ContentPage
	{
		public Modificar (Mpokemoncs pokemon)
		{
			InitializeComponent ();
			BindingContext = new VMeditar(pokemon, Navigation);
		}
	}
}