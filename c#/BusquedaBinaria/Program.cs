using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elementos = new int[] {1,3,5,6,7,8,9,10,13,15,64,66 };
            BusquedaBinaria busqueda = new BusquedaBinaria();
            int buscar=15;
            if (buscar == busqueda.busqueda(elementos, buscar))
            {
                Console.WriteLine("re bien encontraste papa");
            }
            else { 
            
             Console.WriteLine("no encontraste papa");
            }
            Console.ReadKey();
        }
    }
}
