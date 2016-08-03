using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class UserBLL
    {
        public static string usuarioExistente(string user, String pass)
        {
            //declarar las variables
            string mensaje = "";
            bool isExistente = false;
            //validar si contiene datos o no 
            if (string IsNullOrEmpty(user) string.IsNullOrEmpty(pass))
            {
                mensaje = "Existen campos vacios, favor de introduccir usuario y/o contraseña";
            }
            else 
            {
                //validar si el usuario contiene el formato correcto
          if (!IsValidEmail(user))
                {
                    mensaje = "El usuario no contiene el formato deseado, favor de introducir el correcto";
                }
          else
                {

                }
            }
        }
        }

}
