﻿using System;
using System.Collections.Generic;
using System.Text;
using Practica_6_DGGR.Modelo;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using Firebase.Database;
using Practica_6_DGGR.Conexion;

namespace Practica_6_DGGR.Datos
{
    public class Dpokemon
    {
        public async Task InsertarPokemon(Mpokemoncs parametros)
        {
            await Cconexion.firebase
                     .Child("Pokemon")
                 .PostAsync(new Mpokemoncs()
                 {
                     ColorFondo = parametros.ColorFondo,
                     ColorPoder = parametros.ColorPoder,
                     Icono = parametros.Icono,
                     Nombre = parametros.Nombre,
                     NoOrden = parametros.NoOrden,
                     Poder = parametros.Poder
                 }
                 );
        }

        public async Task<ObservableCollection<Mpokemoncs>> MostrarPokemones()
        {
            var data = await Task.Run(() => Cconexion.firebase
            .Child("Pokemon")
            .AsObservable<Mpokemoncs>()
            .AsObservableCollection());
            return data;
            //return (await Cconexion.firebase
            //    .Child("Pokemon")
            //    .OnceAsync<Mpokemoncs>())
            //    .Select(item => new Mpokemoncs
            //    {
            //        Idpokemon = item.Key,
            //        Nombre = item.Object.Nombre,
            //        ColorFondo = item.Object.ColorFondo,
            //        ColorPoder = item.Object.ColorPoder,
            //        Icono = item.Object.Icono,
            //        NoOrden = item.Object.NoOrden,
            //        Poder = item.Object.Poder
            //    }).ToList();
        }
    }
}
