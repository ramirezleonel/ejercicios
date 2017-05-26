using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string abecedario = "aábcdeéfghiíjklmnñoópqrstuúüvwxyzAÁBCDEÉFGHIÍJKLMNÑOÓPQRSTUÚÜVWXYZ";

        static void encriptarMensaje(string mensaje,int clave){
            int posicionDeLetra, cantidadLetra;
            string mensajeEncriptado;
            cantidadLetra = mensaje.Length;
            for (int i = 0; i < cantidadLetra; i++)
            {
                posicionDeLetra = posicionesDeLasLetras(mensaje[i]);
                posicionDeLetra = posicionDeLetra + clave;
                mensajeEncriptado= Convert.ToString( abecedario[posicionDeLetra]);
                Console.WriteLine(mensajeEncriptado);
            }
        
        }

        static void desencriptarMensaje(string mensaje, int clave)
        {
            int posicionDeLetra, cantidadLetra;
            string mensajeEncriptado ;
            cantidadLetra = mensaje.Length;//longitud del mensaje se guarda en mensajeEncriptado
            for (int i = 0; i < cantidadLetra; i++)
            {
                if (mensaje[i] == ' ' || mensaje[i] == ','||mensaje[i]=='.')
                {

                    mensajeEncriptado = Convert.ToString(mensaje[i]);

                }
                else
                {
                    posicionDeLetra = posicionesDeLasLetras(mensaje[i]);
                    posicionDeLetra = posicionDeLetra - clave;
                    if (posicionDeLetra < 0)
                    {

                        posicionDeLetra = (abecedario.Length) + posicionDeLetra;
                    }
                    mensajeEncriptado = Convert.ToString(abecedario[posicionDeLetra]);
                    //guardo el valor
                }
                Console.Write(mensajeEncriptado);
            }

        }
        static int posicionesDeLasLetras(char letra){
        
        for (int i = 0; i < abecedario.Length; i++)
			{
			    if(letra==abecedario[i]){
                
                    return i;
                }
			}
        return -1;//si no lo encuentra devuelve un -1
        }
        static void Main(string[] args)
        {


            Console.WriteLine("EL MENSAJE ENCRIPTADO ES: Mb fcyb dhrqb zbFgéñégr yñ dhRégñ, gi rérf ehüra "+
            "yñ gÜrar ehr ñgéñjrFñé.Üvxaéalaosevélv vjvk vd vdvyaüg. ");
            Console.WriteLine("El MENSAJE DESENCRIPTADO ES: ");
            desencriptarMensaje("Mb fcyb dhrqb zbFgéñégr yñ dhRégñ, gi rérf ehüra yñ gÜrar ehr ñgéñjrFñé.",17);
            desencriptarMensaje("Üvxaéalaosevélv vjvk vd vdvyaüg.", 23);
          
            Console.ReadKey();
        }
    }
}
