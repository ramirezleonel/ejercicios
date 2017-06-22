namespace FormLaberinto
{
    partial class FormPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPresentacion));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayVsCom = new System.Windows.Forms.Button();
            this.btnContraReloj = new System.Windows.Forms.Button();
            this.btnComVsCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODO DE JUEGO";
            
            // 
            // btnPlayVsCom
            // 
            this.btnPlayVsCom.Location = new System.Drawing.Point(33, 317);
            this.btnPlayVsCom.Name = "btnPlayVsCom";
            this.btnPlayVsCom.Size = new System.Drawing.Size(109, 23);
            this.btnPlayVsCom.TabIndex = 1;
            this.btnPlayVsCom.Text = "Player vs Computer";
            this.btnPlayVsCom.UseVisualStyleBackColor = true;
            this.btnPlayVsCom.Click += new System.EventHandler(this.btnPlayVsCom_Click);
            // 
            // btnContraReloj
            // 
            this.btnContraReloj.Location = new System.Drawing.Point(3, 273);
            this.btnContraReloj.Name = "btnContraReloj";
            this.btnContraReloj.Size = new System.Drawing.Size(109, 23);
            this.btnContraReloj.TabIndex = 0;
            this.btnContraReloj.Text = "Contra Reloj";
            this.btnContraReloj.UseVisualStyleBackColor = true;
            this.btnContraReloj.Click += new System.EventHandler(this.btnContraReloj_Click);
            // 
            // btnComVsCom
            // 
            this.btnComVsCom.Location = new System.Drawing.Point(63, 360);
            this.btnComVsCom.Name = "btnComVsCom";
            this.btnComVsCom.Size = new System.Drawing.Size(124, 23);
            this.btnComVsCom.TabIndex = 2;
            this.btnComVsCom.Text = "Computer vs Computer";
            this.btnComVsCom.UseVisualStyleBackColor = true;
            this.btnComVsCom.Click += new System.EventHandler(this.btnComVsCom_Click);
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 395);
            this.Controls.Add(this.btnComVsCom);
            this.Controls.Add(this.btnContraReloj);
            this.Controls.Add(this.btnPlayVsCom);
            this.Controls.Add(this.label1);
            this.Name = "FormPresentacion";
            this.Text = "JUEGO DEL LABERINTO";
            this.Load += new System.EventHandler(this.FormPresentacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayVsCom;
        private System.Windows.Forms.Button btnContraReloj;
        private System.Windows.Forms.Button btnComVsCom;
    }
}