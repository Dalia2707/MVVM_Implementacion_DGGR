using Practica_6_DGGR.Datos;
using Practica_6_DGGR.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica_6_DGGR.VistaModelo.VMpokemon
{
    class VMeditar : BaseViewModel
    {
        #region VARIABLES
        string _ColorFondo;
        string _ColorPoder;
        string _Icono;
        string _Nombre;
        string _NoOrden;
        string _Poder;
        Mpokemoncs _PokeSeleccionado;
        #endregion
        #region CONSTRUCTOR
        public VMeditar(Mpokemoncs pokeSeleccion, INavigation navigation)
        {
            Navigation = navigation;
            _ColorFondo = pokeSeleccion.ColorFondo.ToString();
            _ColorPoder = pokeSeleccion.ColorPoder.ToString();
            _Icono = pokeSeleccion.Icono.ToString();
            _Nombre = pokeSeleccion.Nombre.ToString();
            _NoOrden = pokeSeleccion.NoOrden.ToString();
            _Poder = pokeSeleccion.Poder.ToString();
            _PokeSeleccionado = pokeSeleccion;
        }
        #endregion
        #region OBJETOS
        public string ColorFondo
        {
            get { return _ColorFondo; }
            set { SetValue(ref _ColorFondo, value); }
        }
        public string ColorPoder
        {
            get { return _ColorPoder; }
            set { SetValue(ref _ColorPoder, value); }
        }
        public string Icono
        {
            get { return _Icono; }
            set { SetValue(ref _Icono, value); }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value); }
        }
        public string NoOrden
        {
            get { return _NoOrden; }
            set { SetValue(ref _NoOrden, value); }
        }
        public string Poder
        {
            get { return _Poder; }
            set { SetValue(ref _Poder, value); }
        }
        public Mpokemoncs PokeSeleccionado
        {
            get { return _PokeSeleccionado; }
            set { SetValue(ref _PokeSeleccionado, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ModificarPokemon()
        {
            var funcion = new Dpokemon();
            PokeSeleccionado.Nombre = Nombre;
            PokeSeleccionado.Poder = Poder;
            PokeSeleccionado.NoOrden = NoOrden;
            PokeSeleccionado.Icono = Icono;
            PokeSeleccionado.ColorFondo = ColorFondo;
            PokeSeleccionado.ColorPoder = ColorPoder;
            await funcion.ModificarPokemon(PokeSeleccionado);
            await Volver();
        }
        public async Task EliminarPokemon()
        {
            var funcion = new Dpokemon();
            await funcion.BorrarPokemon(PokeSeleccionado.Idpokemon);
            await DisplayAlert("Eliminado", $"El Pókemon {PokeSeleccionado.Nombre} ah sido eliminado", "OK");
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand ModificarPokemoncomand => new Command(async () => await ModificarPokemon());
        public ICommand EliminarPokemoncomand => new Command(async () => await EliminarPokemon());
        #endregion
    }
}

