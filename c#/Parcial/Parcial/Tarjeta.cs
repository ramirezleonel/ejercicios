/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 07:38 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Parcial
{
	/// <summary>
	/// Description of Tarjeta.
	/// </summary>
	public class Tarjeta:IPago
	{
		    public string Nombre { get; set; }
			public int Numero { get; set; }
			public int Monto { get; set; }
		public Tarjeta(string N,int NUM ,int MONT )
		{
			this.Nombre=N;
			this.Numero=NUM;
			this.Monto=MONT;
			
		}
		
		public int cobro()
		{ return this.Monto;}
	}
}
