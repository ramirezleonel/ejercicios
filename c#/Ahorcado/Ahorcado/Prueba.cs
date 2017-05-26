using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Prueba
    {
        public static void pala() { 
        string palabra="pal";
        StringBuilder p = new StringBuilder(palabra);
        p.ToString();
        if (palabra.Equals(p.ToString()))
        {

            Console.WriteLine("son iguales");
        }
        else {
            Console.WriteLine("no son iguales");
        }

        }
    }
}
