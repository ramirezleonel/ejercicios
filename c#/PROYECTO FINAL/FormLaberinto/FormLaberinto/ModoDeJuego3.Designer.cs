namespace FormLaberinto
{
    partial class ModoDeJuego3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Computer1 = new System.Windows.Forms.Label();
            this.lblTiempo1 = new System.Windows.Forms.Label();
            this.Computer2 = new System.Windows.Forms.Label();
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.TiempoRecorrido1 = new System.Windows.Forms.Timer(this.components);
            this.TiempoRecorrido2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Computer1
            // 
            this.Computer1.AutoSize = true;
            this.Computer1.Location = new System.Drawing.Point(12, 440);
            this.Computer1.Name = "Computer1";
            this.Computer1.Size = new System.Drawing.Size(52, 13);
            this.Computer1.TabIndex = 0;
            this.Computer1.Text = "Computer";
            // 
            // lblTiempo1
            // 
            this.lblTiempo1.AutoSize = true;
            this.lblTiempo1.Location = new System.Drawing.Point(12, 457);
            this.lblTiempo1.Name = "lblTiempo1";
            this.lblTiempo1.Size = new System.Drawing.Size(49, 13);
            this.lblTiempo1.TabIndex = 1;
            this.lblTiempo1.Text = "00:00:00";
            // 
            // Computer2
            // 
            this.Computer2.AutoSize = true;
            this.Computer2.Location = new System.Drawing.Point(690, 440);
            this.Computer2.Name = "Computer2";
            this.Computer2.Size = new System.Drawing.Size(52, 13);
            this.Computer2.TabIndex = 4;
            this.Computer2.Text = "Computer";
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.AutoSize = true;
            this.lblTiempo2.Location = new System.Drawing.Point(690, 457);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(49, 13);
            this.lblTiempo2.TabIndex = 5;
            this.lblTiempo2.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 400);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(393, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 400);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(567, 480);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 12;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // TiempoRecorrido1
            // 
            this.TiempoRecorrido1.Tick += new System.EventHandler(this.TiempoRecorrido1_Tick);
            // 
            // TiempoRecorrido2
            // 
            this.TiempoRecorrido2.Tick += new System.EventHandler(this.TiempoRecorrido2_Tick);
            // 
            // ModoDeJuego3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 573);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTiempo2);
            this.Controls.Add(this.Computer2);
            this.Controls.Add(this.lblTiempo1);
            this.Controls.Add(this.Computer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModoDeJuego3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModoDeJuego3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModoDeJuego3_FormClosed);
            this.Load += new System.EventHandler(this.ModoDeJuegoCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Computer1;
        private System.Windows.Forms.Label lblTiempo1;
        private System.Windows.Forms.Label Computer2;
        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Timer TiempoRecorrido1;
        private System.Windows.Forms.Timer TiempoRecorrido2;
    }
}