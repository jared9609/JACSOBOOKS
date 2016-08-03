using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindFormapp
{
    class Datos
    {
        private static string acceso;
        private static string ac;

        public static string Acceso
        {
            get
            {
                return acceso;
            }

            set
            {
                acceso = value;
            }
        }

        public static string Ac
        {
            get
            {
                return ac;
            }

            set
            {
                ac = value;
            }
        }
    }
}
