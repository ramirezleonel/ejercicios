/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 08:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ventanas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void ButPantalla2Click(object sender, EventArgs e)
		{
			Form2 F=new Form2();
			F.anterior=this;
			F.Show();
			
		}
	}
}
