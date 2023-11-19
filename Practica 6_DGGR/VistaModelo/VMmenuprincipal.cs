using Practica_6_DGGR.Modelo;
using Practica_6_DGGR.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica_6_DGGR.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
            #region VARIEBLES
            string _Texto;
            public List<Mmenuprincipal> Listausuarios { get; set; }
            #endregion
            #region CONTRUCTOR
            public VMmenuprincipal(INavigation navigation)
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
                Listausuarios = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://i.ibb.co./gvpcDWw/pescado.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "CollectionView sin enlace a Base de datos",
                    Icono = "https://i.ibb.co/RSrm1rJ/pulpo.png"
                },
                new Mmenuprincipal
                {
                    Pagina = "Carlos",
                    Icono = "https://i.ibb.co/ZLCmpR7/caja-de-leche.png"
                }
            };

            }
            public async Task Navegar(Mmenuprincipal parametros)
            {
                string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            if (pagina.Contains("Crudd pockemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
            }
            #endregion
            #region COMANDO
            public ICommand VolverCommand => new Command(async () => await Volver());
            //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
            public ICommand NavegarCommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
            #endregion
        }
    }

