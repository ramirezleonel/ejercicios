using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class BusquedaBinaria
    {
        public int busqueda(int[]valores,int encontrado) {
            int primero=0;
            int ultimo=valores.Length-1;
            int medio;

            while (primero <= ultimo)
            {
                medio = (primero + ultimo) / 2;
                if (encontrado == valores[medio])
                    return encontrado;
                else if (encontrado > valores[medio])
                {
                    primero = medio + 1;

                }
                else if (encontrado < valores[medio])
                {
                    ultimo = medio - 1;

                }
            }
            return -1;
        }
    }
}
