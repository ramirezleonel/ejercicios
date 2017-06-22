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
    public partial class ModoDeJuego3 : Form
    {
         int tamañoCeldaD = Cell.kCellSize - 5;
        Graphics g1,g2;
        Tiempo tiempo1,tiempo2;
        public bool generado;
        private Cell celdaMovil;
        private Maze TheMaze;
    
        public ModoDeJuego3()
        {  //creo el laberinto
            TheMaze = new Maze();
            //es falso cuando recien inicia el form
            generado = false;
           
            InitializeComponent();
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Maze.kDimension = 10;

            TheMaze.Initialize();
            //TheMaze.Generate();
            g1 = pictureBox1.CreateGraphics();
            g2 = pictureBox2.CreateGraphics();
            g1.FillRectangle(Brushes.White, ClientRectangle);
            g2.FillRectangle(Brushes.White, ClientRectangle);
            //dimensiones del laberinto ya resuelto
            TheMaze.Generate();
            TheMaze.Draw(g1);
            TheMaze.Draw(g2);

            //encuentra el punto de inicio y fin de forma aleatoria
            TheMaze.encontrarInicioFin(g1);
            TheMaze.encontrarInicioFin(g2);
            celdaMovil = Maze.inicio;

            //si el laberinto esta generado va a hacer true
            generado = true;

            //genera tiempo
            generarTiempo();
            timer1.Enabled = true;
            timer2.Enabled = true;
            TheMaze.recorrerProfundidad(Maze.inicio, Maze.fin, g1);
            TheMaze.recorrerProfundidad(Maze.inicio, Maze.fin, g2);  
        }
        private void ModoDeJuegoCom_Load(object sender, EventArgs e)
        {
            
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblTiempo1.Enabled)
            {

                tiempo1.Seg++;
                if (tiempo1.Seg == 60)
                {
                    tiempo1.Min++;
                    tiempo1.Seg = 00;
                }
                if (tiempo1.Min == 60)
                {
                    tiempo1.Hora++;
                    tiempo1.Min = 00;

                }
                lblTiempo1.Text = tiempo1.ToString();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lblTiempo2.Enabled)
            {

                tiempo2.Seg++;
                if (tiempo2.Seg == 60)
                {
                    tiempo2.Min++;
                    tiempo2.Seg = 00;
                }
                if (tiempo2.Min == 60)
                {
                    tiempo2.Hora++;
                    tiempo2.Min = 00;

                }
                lblTiempo2.Text = tiempo2.ToString();
                //padleft inserta un caracter a la izquierda hasta alcanzar el total osea 2
            }
        }

        public string compararTiempo()
        {
            int tiempo;
            TimeSpan intervalo1 = new TimeSpan(tiempo1.Hora, tiempo1.Min, tiempo1.Seg);
            TimeSpan intervalo2 = new TimeSpan(tiempo2.Hora, tiempo2.Min, tiempo2.Seg);
            tiempo = TimeSpan.Compare(intervalo1, intervalo2);
            //si son iguales
            if (tiempo == 0)
            {
                return "Hay un empate";
            }
            else if (tiempo > 0)
            {
                return "ha ganado el player1 : tiempo ";
            }
            else
            {
                return "ha ganado el player2";
            }
        }


       

        
        public void generarTiempo()
        {
            lblTiempo1.Enabled = true;
            tiempo1 = new Tiempo(00, 00, 00);
            lblTiempo2.Enabled = true;
            tiempo2 = new Tiempo(00, 00, 00);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
