namespace Simon
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
            this.components = new System.ComponentModel.Container();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnCeleste = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(31, 205);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerde.Location = new System.Drawing.Point(31, 51);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(85, 50);
            this.btnVerde.TabIndex = 1;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            this.btnVerde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerde_MouseDown);
            this.btnVerde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVerde_MouseUp);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(154, 51);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(85, 50);
            this.btnRojo.TabIndex = 2;
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRojo_MouseDown);
            this.btnRojo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRojo_MouseUp);
            // 
            // btnCeleste
            // 
            this.btnCeleste.Location = new System.Drawing.Point(31, 123);
            this.btnCeleste.Name = "btnCeleste";
            this.btnCeleste.Size = new System.Drawing.Size(85, 50);
            this.btnCeleste.TabIndex = 3;
            this.btnCeleste.UseVisualStyleBackColor = true;
            this.btnCeleste.Click += new System.EventHandler(this.btnCeleste_Click);
            this.btnCeleste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCeleste_MouseDown);
            this.btnCeleste.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCeleste_MouseUp);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.Location = new System.Drawing.Point(154, 123);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(85, 50);
            this.btnAmarillo.TabIndex = 4;
            this.btnAmarillo.UseVisualStyleBackColor = true;
            this.btnAmarillo.Click += new System.EventHandler(this.btnAmarillo_Click);
            this.btnAmarillo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAmarillo_MouseDown);
            this.btnAmarillo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAmarillo_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puntos:0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnCeleste);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnJugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnCeleste;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

