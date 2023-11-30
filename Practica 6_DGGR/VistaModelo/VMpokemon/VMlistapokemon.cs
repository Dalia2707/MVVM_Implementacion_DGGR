using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Practica_6_DGGR.Modelo;
using Practica_6_DGGR.Vista.Pokemon;
using Practica_6_DGGR.Datos;
using System.Collections.ObjectModel;


namespace Practica_6_DGGR.VistaModelo.VMpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        #region VARIEBLES
        string _Texto;
        ObservableCollection<Mpokemoncs> _Listapokemon;
        #endregion
        #region CONTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mpokemoncs> Listapokemon
        {
            get { return _Listapokemon; }
            set
            {
                SetValue(ref _Listapokemon, value);
                OnpropertyChanged();
            }
        }
        #endregion
        #region PROCESOS

        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        }
        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDO
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand Mostrarpokemoncommand => new Command(async () => await Mostrarpokemon());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
