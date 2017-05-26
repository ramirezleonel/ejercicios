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
    public partial class Form1 : Form
    {
        Biblioteca biblioteca1=new Biblioteca();
        
        
        public Form1()
        {
            InitializeComponent();
            biblioteca1.agregarLibros(new Libro("Hector Abad", "Angosta"));
            biblioteca1.agregarLibros(new Libro("Mario Bellatin", "Salón de belleza"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
     
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           
            //biblioteca1.libros.Add(new Libro("Yuri Herrera", "Los trabajos del reino") );
            

            foreach (Libro item in biblioteca1.libros)
            {
                textBox1.Text = item.describir();



            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
