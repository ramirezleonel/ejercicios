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
    public partial class Niveles : Form
    {
        public Niveles()
        {
            InitializeComponent();
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            ModoDeJuego2 mdj2 = new ModoDeJuego2(400);
            this.Hide();
            mdj2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModoDeJuego2 mdj2 = new ModoDeJuego2(300);
            this.Hide();
            mdj2.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModoDeJuego2 mdj2 = new ModoDeJuego2(150);
            this.Hide();
            mdj2.ShowDialog();
            this.Close();
        }
    }
}
