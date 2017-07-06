/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 07:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Parcial
{
	/// <summary>
	/// Description of Paypal.
	/// </summary>
	public class Paypal:IPago
	{
		public string Email { get; set; }
		public int Monto { get; set; }
		
		public Paypal(string e, int MONT)
		{this.Email=e;
			this.Monto=MONT;
		
		}
		public int cobro()
		{ return this.Monto;}
	}
}
