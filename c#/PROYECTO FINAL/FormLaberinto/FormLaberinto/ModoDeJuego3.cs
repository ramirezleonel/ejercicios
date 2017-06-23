using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace FormLaberinto
{
    public partial class ModoDeJuego3 : Form
    {
        int cantDeCeldas1 = 0;
        int cantDeCeldas2=0;
        public List<Cell> recorrido1,recorrido2;
         int tamañoCeldaD = Cell.kCellSize - 5;
        Graphics g1,g2;
        Tiempo tiempo1,tiempo2;
        public bool generado;
        private Cell celdaMovil;
        private Maze TheMaze,TheMaze2;//se generan dos laberintos
    
        public ModoDeJuego3()
        {  //creo el laberinto
            TheMaze = new Maze();
            //es falso cuando recien inicia el form
            generado = false;
           
            InitializeComponent();
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            cantDeCeldas1 = 0;
            cantDeCeldas2 = 0;
            Maze.kDimension = 10;

            TheMaze.Initialize();
            //TheMaze.Generate();
            g1 = pictureBox1.CreateGraphics();
            g2 = pictureBox2.CreateGraphics();
            g1.FillRectangle(Brushes.White, ClientRectangle);
            g2.FillRectangle(Brushes.White, ClientRectangle);
            //dimensiones del laberinto ya resuelto
            TheMaze.Generate();
            TheMaze2 = new Maze();
            TheMaze.asignarMismoLaberinto(TheMaze2);
            TheMaze.Draw(g1);
            TheMaze2.Draw(g2);

            //encuentra el punto de inicio y fin de forma aleatoria
            TheMaze.encontrarInicioFin(g1);
            TheMaze2.encontrarInicioFin(g2);
            celdaMovil = TheMaze.inicio;

            //si el laberinto esta generado va a hacer true
            generado = true;

            //genera tiempo
            generarTiempo();
            timer1.Enabled = true;
            timer2.Enabled = true;
            recorrido1=TheMaze.recorrerProfundidad(TheMaze.inicio, TheMaze.fin, g1);
            recorrido2 = TheMaze2.recorrerProfundidad(TheMaze2.inicio, TheMaze2.fin, g2);
         
            TiempoRecorrido1.Start();// tiempo recorrido1 de computer1
            TiempoRecorrido2.Start();// tiempo recorrido2 de computer2
        }
        private void ModoDeJuegoCom_Load(object sender, EventArgs e)
        {

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
                return "Hay un empate \n" + "Computer 1 : " + intervalo1 + "\n Computer 2: " + intervalo2;
            }
            //si el intervalo1 es menor que el intervalo2 devuelve un -1
            else if (tiempo < 0)
            {
                return "haz ganado \n " + "Computer 1 : " + intervalo1 + "\n Computer 2: " + intervalo2;
            }
            //si el intervalo1 es mayor que el intervalo2 devuelve un 1
            else
            {
                return "haz perdido " + "Computer 1 : " + intervalo1 + "\n Computer 2: " + intervalo2;
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

       


        private void TiempoRecorrido2_Tick(object sender, EventArgs e)
        {


            if (cantDeCeldas2 <= recorrido2.Count - 1)
            {
                g2.FillRectangle(Brushes.Gold, recorrido2[cantDeCeldas2].coleccionPuntos[0].X + 2.5f, recorrido2[cantDeCeldas2].coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);

                cantDeCeldas2++;
            }
            else
            {
                lblTiempo2.Enabled = false;//se deshabilita el label donde muestra el tiempo
                if (lblTiempo1.Enabled == false && lblTiempo2.Enabled == false)
                {
                    TiempoRecorrido2.Stop();
                    MessageBox.Show(compararTiempo());
                    this.Close();

                }

            }


        }

        private void TiempoRecorrido1_Tick(object sender, EventArgs e)
        {
            //cantdeCeldas es una variable para saber cuantas va recorriendo

            if (cantDeCeldas1 <= recorrido1.Count - 1)
            {
                g1.FillRectangle(Brushes.Gold, recorrido1[cantDeCeldas1].coleccionPuntos[0].X + 2.5f, recorrido1[cantDeCeldas1].coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);

                cantDeCeldas1++;
            }
            else
            {
                lblTiempo1.Enabled = false;//se deshabilita el label donde muestra el tiempo
                if (lblTiempo1.Enabled == false && lblTiempo2.Enabled == false)
                {
                    TiempoRecorrido1.Stop();
                    MessageBox.Show(compararTiempo());
                    this.Close();

                }

            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
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
                lblTiempo2.Text = tiempo1.ToString();

            }
            else
            {

                timer2.Stop();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
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
            else
            {

                timer1.Stop();
            }
        }

        private void ModoDeJuego3_FormClosed(object sender, FormClosedEventArgs e)
        {
            TiempoRecorrido1.Stop();
            TiempoRecorrido2.Stop();
        }
    }
}
