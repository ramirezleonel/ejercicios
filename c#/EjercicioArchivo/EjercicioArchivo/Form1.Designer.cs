namespace EjercicioArchivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.btnAcep = new System.Windows.Forms.Button();
            this.listDirectorio = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(25, 67);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(229, 20);
            this.txtDirectorio.TabIndex = 0;
            this.txtDirectorio.TextChanged += new System.EventHandler(this.txtDirectorio_TextChanged);
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(22, 41);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(95, 13);
            this.lblDirectorio.TabIndex = 1;
            this.lblDirectorio.Text = "Ruta del Directorio";
            // 
            // btnAcep
            // 
            this.btnAcep.Location = new System.Drawing.Point(179, 249);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(75, 23);
            this.btnAcep.TabIndex = 2;
            this.btnAcep.Text = "Aceptar";
            this.btnAcep.UseVisualStyleBackColor = true;
            this.btnAcep.Click += new System.EventHandler(this.btnAcep_Click);
            // 
            // listDirectorio
            // 
            this.listDirectorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listDirectorio.Location = new System.Drawing.Point(25, 104);
            this.listDirectorio.Name = "listDirectorio";
            this.listDirectorio.Size = new System.Drawing.Size(229, 139);
            this.listDirectorio.TabIndex = 3;
            this.listDirectorio.UseCompatibleStateImageBehavior = false;
            this.listDirectorio.View = System.Windows.Forms.View.Tile;
            this.listDirectorio.SelectedIndexChanged += new System.EventHandler(this.listDirectorio_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ruta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.listDirectorio);
            this.Controls.Add(this.btnAcep);
            this.Controls.Add(this.lblDirectorio);
            this.Controls.Add(this.txtDirectorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.Button btnAcep;
        private System.Windows.Forms.ListView listDirectorio;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

