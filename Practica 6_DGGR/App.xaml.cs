using Practica_6_DGGR.Vista;
using Practica_6_DGGR.Vista.Pokemon;
using Practica_6_DGGR.VistaModelo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_6_DGGR

{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Registrarpokemon());
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
