/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 09:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ventanas
{
	/// <summary>
	/// Description of FormTERCERNIVEL.
	/// </summary>
	public partial class FormTERCERNIVEL : Form
	{
		public Form2 VentAnt { get; set; }
		
		public FormTERCERNIVEL()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void FormTERCERNIVELLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (VentAnt!=null) {
				VentAnt.pers=new Personas(textBox1.Text,textBox2.Text);
			}
			
			this.Close();
			
			
		}
	}
}
