using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica_6_DGGR.VistaModelo
{
    class VMPagina2
    {
        public VMPagina2(INavigation navigation)
        {
        }

        internal class VMpatron : BaseViewModel
        {
            #region VARIEBLES
            string _Texto;
            #endregion
            #region CONTRUCTOR
            public VMpatron(INavigation navigation)
            {
                Navigation = navigation;
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
            public void ProcesoSimple()
            {

            }
            #endregion
            #region COMANDO
            public ICommand VolverCommand => new Command(async () => await Volver());
            public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
            #endregion
        }
    }

}

