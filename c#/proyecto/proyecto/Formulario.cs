using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2
{
    public partial class Formulario : Form
    {
        Libro[] biblioteca = { new Libro("Ricardo Piglia", "Plata Quemada"),
                                    new Libro("Yuri Herrera", "Los trabajos del reino"),
                                    new Libro("Hector Abad","Angosta"),
                                    new Libro("Cristina Rivera Garza","Nadie me verá llorar"),
                                    new Libro("Mario Bellatin","Salón de belleza"),
                                    new Libro("Mario Levrero","La novela luminosa")
                                     };
        public void recorrerBiblioteca() {
            for (int i = 0; i < biblioteca.Length; i++)
            {
                textBox1.Text += biblioteca[i] + "\r\n";
            }
        
        }
        public Formulario()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            recorrerBiblioteca();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {       
            }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
          
            //ordena el arreglo
            Array.Sort(biblioteca);
            textBox1.Clear();
            recorrerBiblioteca();
        }

        }
    }

