using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Practica_6_DGGR.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvm-dggr-default-rtdb.firebaseio.com/");
    }
}
