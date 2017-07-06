/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 09:17 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ventanas
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Personas
	{
		public string Nombre { get; set; }
		public string direccion { get; set; }
		
		public Personas(string n,string d)
		{
			this.Nombre=n;
			this.direccion=d;
		}
	}
}
