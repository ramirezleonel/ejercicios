/*
 * Created by SharpDevelop.
 * User: Placido
 * Date: 11/05/2017
 * Time: 08:49 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ventanas
{
	partial class Inicial
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menu = new System.Windows.Forms.MenuStrip();
			this.pantalla1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pantalla2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pantalla3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pantalla2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pantalla1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.pantalla1ToolStripMenuItem,
									this.pantalla2ToolStripMenuItem,
									this.pantalla3ToolStripMenuItem});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(479, 24);
			this.menu.TabIndex = 0;
			this.menu.Text = "menuStrip1";
			// 
			// pantalla1ToolStripMenuItem
			// 
			this.pantalla1ToolStripMenuItem.Name = "pantalla1ToolStripMenuItem";
			this.pantalla1ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.pantalla1ToolStripMenuItem.Text = "Pantalla1";
			this.pantalla1ToolStripMenuItem.Click += new System.EventHandler(this.Pantalla1);
			// 
			// pantalla2ToolStripMenuItem
			// 
			this.pantalla2ToolStripMenuItem.Name = "pantalla2ToolStripMenuItem";
			this.pantalla2ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.pantalla2ToolStripMenuItem.Text = "Pantalla2";
			this.pantalla2ToolStripMenuItem.Click += new System.EventHandler(this.Pantalla2);
			// 
			// pantalla3ToolStripMenuItem
			// 
			this.pantalla3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.pantalla2ToolStripMenuItem1,
									this.pantalla1ToolStripMenuItem1,
									this.salirToolStripMenuItem});
			this.pantalla3ToolStripMenuItem.Name = "pantalla3ToolStripMenuItem";
			this.pantalla3ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.pantalla3ToolStripMenuItem.Text = "Pantalla3";
			// 
			// pantalla2ToolStripMenuItem1
			// 
			this.pantalla2ToolStripMenuItem1.Name = "pantalla2ToolStripMenuItem1";
			this.pantalla2ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			this.pantalla2ToolStripMenuItem1.Text = "Pantalla2";
			this.pantalla2ToolStripMenuItem1.Click += new System.EventHandler(this.Pantalla2ToolStripMenuItem1Click);
			// 
			// pantalla1ToolStripMenuItem1
			// 
			this.pantalla1ToolStripMenuItem1.Name = "pantalla1ToolStripMenuItem1";
			this.pantalla1ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			this.pantalla1ToolStripMenuItem1.Text = "Pantalla1";
			this.pantalla1ToolStripMenuItem1.Click += new System.EventHandler(this.Pantalla1ToolStripMenuItem1Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salir);
			// 
			// Inicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 261);
			this.Controls.Add(this.menu);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menu;
			this.Name = "Inicial";
			this.Text = "Inicial";
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pantalla1ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem pantalla2ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem pantalla3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pantalla2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pantalla1ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menu;
	}
}
