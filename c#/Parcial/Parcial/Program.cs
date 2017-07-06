/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 07:31 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			List<Pasajero>  PrimeraClase=new List<Pasajero>();
			
			PrimeraClase.Add(new Pasajero("Pablo",new Tarjeta("Nativa",2045450,500)));
			PrimeraClase.Add(new Pasajero("Pedro",new Tarjeta("Naranja",4541516,500)));
			PrimeraClase.Add(new Pasajero("Ricardo",new Paypal("ricardo@alskdf.com",400)));
			PrimeraClase.Add(new Pasajero("Gonzalo",new Paypal("gonza@alsdkf.com",400)));
			PrimeraClase.Add(new Pasajero("Candela",new Tarjeta("Nativa",565655,500)));
			
		
         foreach (var Pasaj in PrimeraClase) {
	   
				
				
				
				if (Pasaj.pago is Paypal) {
					
					Console.WriteLine(" Pago por Paypal el Sr. {0}  ${1}",Pasaj.Nombre, Pasaj.pago.cobro() );
			
				}
           }			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}