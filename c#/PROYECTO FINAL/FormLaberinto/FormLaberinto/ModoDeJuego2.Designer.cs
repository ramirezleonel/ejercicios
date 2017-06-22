namespace FormLaberinto
{
    partial class ModoDeJuego2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnJugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTiempo1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.TiempoRecorrido = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(393, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 400);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(577, 461);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player";
            // 
            // lblTiempo1
            // 
            this.lblTiempo1.AutoSize = true;
            this.lblTiempo1.Enabled = false;
            this.lblTiempo1.Location = new System.Drawing.Point(9, 446);
            this.lblTiempo1.Name = "lblTiempo1";
            this.lblTiempo1.Size = new System.Drawing.Size(49, 13);
            this.lblTiempo1.TabIndex = 5;
            this.lblTiempo1.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Computer";
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.AutoSize = true;
            this.lblTiempo2.Enabled = false;
            this.lblTiempo2.Location = new System.Drawing.Point(690, 446);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(49, 13);
            this.lblTiempo2.TabIndex = 7;
            this.lblTiempo2.Text = "00:00:00";
            // 
            // TiempoRecorrido
            // 
            this.TiempoRecorrido.Interval = 60;
            this.TiempoRecorrido.Tick += new System.EventHandler(this.TiempoRecorrido_Tick);
            // 
            // ModoDeJuego2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 573);
            this.Controls.Add(this.lblTiempo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTiempo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModoDeJuego2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModoDeJuego2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModoDeJuego2_FormClosed);
            this.Load += new System.EventHandler(this.ModoDeJuego2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTiempo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.Timer TiempoRecorrido;
    }
}