/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 08:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Ventanas
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Personas pers { get; set; }
		List<Personas> TAB=new List<Personas>();
		
		public Form anterior { get; set; }
		
		
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			FormTERCERNIVEL f=new FormTERCERNIVEL();
			f.MdiParent=this.MdiParent;
			f.VentAnt=this;
		    f.Show();
		}
		
		void Form2Activated(object sender, EventArgs e)
		{
			
			if (pers!=null) {
				
		    MessageBox.Show(pers.Nombre);
			TAB.Add(pers);
			dataGridView1.DataSource=null;
			dataGridView1.DataSource=TAB;
			}
			
		}
		
		void Form2Load(object sender, EventArgs e)
		{
			
			TAB.Add(new Personas("Pedro Marmol","Los Sauces 55"));
			TAB.Add(new Personas("PABLO PICAPIEDRA","Los alerces 55"));
			TAB.Add(new Personas("LENADRO Marmol","Los Sauces 555"));
			TAB.Add(new Personas("MARCOS QUINTERO","Los Robles 55"));
			TAB.Add(new Personas("Pedro Carabajal","Los Pinos 55"));
			TAB.Add(new Personas("Pedro Camacho","Los Cedros 55"));
			
		
			
			dataGridView1.DataSource=TAB;
			
			
			
			
			
		}
	}
}
