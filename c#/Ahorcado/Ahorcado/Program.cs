using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhorcadoPalabras;
namespace Ahorcado

{
    class Program
    {
        public static void ahorcado(string p) {
            Char caracter=' ';
            StringBuilder pal = new StringBuilder(p);
            pal=enmascarar(pal);//enmascaro
            int posibilidades = 6;
            while (posibilidades > 0)
            {
                if (!p.Equals(pal.ToString()))
                {
                    int contador = 0;
                    Console.WriteLine(pal);
                    Console.WriteLine("ingrese caracter");
                    caracter = Convert.ToChar(Console.ReadLine());

                    for (int i = 0; i < p.Length; i++)
                    {
                        if (caracter == p[i])
                        {

                            pal[i] = caracter;//le cambio por el caracter encontrado
                            contador++;
                        }
                    }
                    if (contador == 0)
                    {
                        
                        posibilidades--;
                        Console.WriteLine("No haz Acertado,te quedan {0}!!",posibilidades);
                    }
                    else
                    {
                        Console.WriteLine("Acertaste!!");
                    }


                }
                else {

                    Console.WriteLine("GANASTEE");
                    return;
                }


            }
            Console.WriteLine("PERDISTE");
        }
        public static StringBuilder enmascarar(StringBuilder palabra ) {

            for (int i = 0; i < palabra.Length; i++)
            {
                palabra[i] = 'x';
            }
            return palabra;
        }

        static void Main(string[] args)
        {
            GeneradorPalabras palabra = new GeneradorPalabras();
            //palabra random
            string palabraAhorcado = palabra.SiguientePalabra;


            Console.WriteLine("la palabra :" + palabraAhorcado);
            //empezar juego del ahorcado
            ahorcado(palabraAhorcado);


            Console.ReadKey();
        }
    }
}
