using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLaberinto
{
    public partial class FormPresentacion : Form
    {
       
        public FormPresentacion()
        {
            InitializeComponent();
        }

        private void FormPresentacion_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;// no se puede maximizar
        }

        private void btnContraReloj_Click(object sender, EventArgs e)
        {
            
            Form form=new Form1();
                form.ShowDialog();

        }

        private void btnPlayVsCom_Click(object sender, EventArgs e)
        {
            Niveles dificultad = new Niveles();
            dificultad.ShowDialog();
                  }

        private void btnComVsCom_Click(object sender, EventArgs e)
        {
            ModoDeJuego3 mdj3 = new ModoDeJuego3();
            mdj3.ShowDialog();
        }
    }
}
