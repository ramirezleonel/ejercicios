/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 07:33 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Parcial
{
	/// <summary>
	/// Description of Pasajero.
	/// </summary>
	public class Pasajero
	{
		public string Nombre { get; set; }
		public IPago pago { get; set; }
		public Pasajero(string nom,IPago p)
		{
			this.Nombre=nom;
			this.pago=p;
			
		
		}
	}
}
