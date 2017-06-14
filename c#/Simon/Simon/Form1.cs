using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form1 : Form
    {
        List<int> listaDeBotones=new List<int>();
        Random aleatorio = new Random();
        bool mostrandoSecuencia=false;
        public int contadorSecuencia=0,contadorDeTicks;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            
         
            jugar();
            
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            listaDeBotones.Add(aleatorio.Next(0, 4));
        }

        public void jugar() {
            mostrandoSecuencia = true;
            foreach (int item in listaDeBotones)
            {
                timer2.Start();
                switch (item) { 
                    case 0:
                        btnVerde.BackColor = Color.Green;
                        timer2.Start();
                        timer1.Start();
                        
                        break;
                    case 1:
                         btnRojo.BackColor = Color.Red;
                         timer2.Start();
                         timer1.Start();
                      
                        break;
                    case 2:
                         btnCeleste.BackColor = Color.LightBlue;
                         timer2.Start();
                         timer1.Start();
                     
                        break;
                    case 3:
                         btnAmarillo.BackColor = Color.Yellow;
                         timer2.Start();
                         timer1.Start();
                   
                        break;
                                        
                }
                timer2.Start();
               
            }
            mostrandoSecuencia= false;
            
        }

        void verCorrecto(int boton){
            if (mostrandoSecuencia!= false)
            {
                //si esta ejecutando la secuencia, no hace nada
                return;
            }
            if (listaDeBotones[contadorSecuencia]== boton)//contadorsecuencia me dice cuantas posiciones tiene la lista
            {
                contadorSecuencia++;
            }
            else {
                timer1.Start();
                MessageBox.Show("Perdiste!. Total Puntos:"+listaDeBotones.Count.ToString());
                contadorSecuencia = 0;
                listaDeBotones=new List<int>();
                
            }
            if (contadorSecuencia == listaDeBotones.Count) {

                listaDeBotones.Add(aleatorio.Next(0,4));
                contadorSecuencia = 0;//lo vuelvo a cero para volver a mostrar toda la lista
                jugar();
            }
            
        
        }
        private void btnVerde_Click(object sender, EventArgs e)
        {
            
        }
        private void btnRojo_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCeleste_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void btnVerde_MouseUp(object sender, MouseEventArgs e)
        {
            btnVerde.BackColor = DefaultBackColor;
        }

        private void btnVerde_MouseDown(object sender, MouseEventArgs e)
        {
            btnVerde.BackColor = Color.Green;
            verCorrecto(0);
        }

        private void btnRojo_MouseUp(object sender, MouseEventArgs e)
        {
            btnRojo.BackColor = DefaultBackColor;
        }

        private void btnRojo_MouseDown(object sender, MouseEventArgs e)
        {
            btnRojo.BackColor = Color.Red;
            verCorrecto(1);
        }

        private void btnCeleste_MouseUp(object sender, MouseEventArgs e)
        {
            btnCeleste.BackColor = DefaultBackColor;
        }

        private void btnCeleste_MouseDown(object sender, MouseEventArgs e)
        {
            btnCeleste.BackColor = Color.LightBlue;
            verCorrecto(2);
        }

        private void btnAmarillo_MouseUp(object sender, MouseEventArgs e)
        {
            btnAmarillo.BackColor = DefaultBackColor;
        }

        

        private void btnAmarillo_MouseDown(object sender, MouseEventArgs e)
        {
            btnAmarillo.BackColor = Color.Yellow;
            verCorrecto(3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRojo.BackColor = Color.Transparent;
            btnVerde.BackColor = Color.Transparent;
            btnAmarillo.BackColor = Color.Transparent;
            btnCeleste.BackColor = Color.Transparent;
            
           
            timer1.Stop();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (contadorDeTicks > 100) {
                timer2.Stop();
            
            }
            contadorDeTicks++;
        }

   

      

    }
}
