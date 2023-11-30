using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica_6_DGGR.VistaModelo.VMpokemon;
using Practica_6_DGGR.Vista.Pokemon;

namespace Practica_6_DGGR.Vista.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Listapokemon : ContentPage
	{
		public Listapokemon ()
		{
			InitializeComponent ();
			BindingContext = new VMlistapokemon(Navigation);
		}
	}
}