using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {

        public static void moda( int[] valor) {
            int [] aux=new int[valor.Length];
            int max = valor[0], min = valor[0], contador = 0;
            for (int i = 0; i < valor.Length; i++)
            {
                
                for (int j = i; j < valor.Length; j++)
                {
                    if (valor[i]== valor[j]) {
                        contador++;
                    
                    }
                   
                }
                aux[i] = contador;
                contador = 0;
            }
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == aux.Max())
                {
                    //Console.WriteLine(valor[i]);}
                }
                valor = aux;
                //Console.WriteLine("min= "+valor.Min()+" max= "+valor.Max());
            }
        }
        static void Main(string[] args)
        {
            int[] valores={6,2,4,5,7,7,8,4,321,231,321,51,151,15};
            
            moda( valores);
            foreach (int val in valores)
	{
		 Console.WriteLine(val);
	}
            
            Console.ReadKey();

        }
         //Console.Write(valor[i] + " ");
                //if(max<valor[i]){
                  //  max = valor[i];
                
                //}
                //if(min>valor[i]){
                  //  min = valor[i];
                //}
    }
}
