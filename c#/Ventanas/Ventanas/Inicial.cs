/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 08:49 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ventanas
{
	/// <summary>
	/// Description of Inicial.
	/// </summary>
	public partial class Inicial : Form
	{
		public Inicial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButForm1Click(object sender, EventArgs e)
		{ 
			
		}
		
		
		
		void Pantalla1(object sender, EventArgs e)
		{
			MainForm m=new MainForm();
			m.MdiParent=this;
			m.Show();
			
		}
		
		void Pantalla2(object sender, EventArgs e)
		{
			Form2 F=new Form2();
			F.MdiParent=this;
			F.Show();
		}
		
		void Pantalla2ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			MainForm m=new MainForm();
			m.MdiParent=this;
			m.Show();
			
		}
		
		void Pantalla1ToolStripMenuItem1Click(object sender, EventArgs e)
		{
            Form2 F=new Form2();
            F.MdiParent=this;
			F.Show();			
		}
		
	
		
		void salir(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
