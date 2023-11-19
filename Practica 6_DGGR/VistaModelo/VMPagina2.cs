using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Practica_6_DGGR.Modelo;
using Practica_6_DGGR.Vista;

namespace Practica_6_DGGR.VistaModelo
{

        public class VMPagina2 : BaseViewModel
        {
            #region VARIEBLES
            string _Texto;
            public List<Mususarios> Listausuarios {  get; set; }
            #endregion
            #region CONTRUCTOR
            public VMPagina2(INavigation navigation)
            {
                Navigation = navigation;
                Mostrarusuarios();
                
            }
            #endregion
            #region OBJETOS

            public string Texto
            {
                get { return _Texto; }
                set { SetValue(ref _Texto, value); }
            }

            #endregion
            #region PROCESOS
            public async Task Volver()
            {
               await Navigation.PopAsync();
            }
            public void Mostrarusuarios()
            {
                Listausuarios = new List<Mususarios>
            {
                new Mususarios
                {
                    Nombre = "frank",
                    Imagen = "https://i.ibb.co./gvpcDWw/pescado.png"
                },
                new Mususarios
                {
                    Nombre = "Juan",
                    Imagen = "https://i.ibb.co/RSrm1rJ/pulpo.png"
                },
                new Mususarios
                {
                    Nombre = "Carlos",
                    Imagen = "https://i.ibb.co/ZLCmpR7/caja-de-leche.png"
                }
            };

            }
        public async Task Alerta(Mususarios parametros)
        {
            await DisplayAlert("Titulo",parametros.Nombre , "Ok");
        }
        #endregion
        #region COMANDO
        public ICommand VolverCommand => new Command(async () => await Volver());
            //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand AlertaCommand => new Command<Mususarios>(async (p) => await Alerta(p));
            #endregion
        }
    }


