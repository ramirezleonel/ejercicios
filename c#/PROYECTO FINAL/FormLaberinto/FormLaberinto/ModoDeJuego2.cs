using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLaberinto
{
    public partial class ModoDeJuego2 : Form
    {
        int cantDeCeldas = 0;// se utiliza para recorrer la list -recorrido- sabiendo la cantidad de celdas que fueron visitadas
        public List<Cell>recorrido;
        int tamañoCeldaD = Cell.kCellSize - 5;
        Graphics g1,g2;
        Tiempo tiempo1,tiempo2;
        public bool generado;
        private Cell celdaMovil;
        private Maze TheMaze;
        public ModoDeJuego2(int intervaloDeTiempo)
        {
            //creo el laberinto
            TheMaze = new Maze();
            //es falso cuando recien inicia el form
            generado = false;
           
            InitializeComponent();
            TiempoRecorrido.Interval = intervaloDeTiempo;//el intervalo del timer cuanto mas grande su valor mas tiempo tarda en recorrer
        }

        private void ModoDeJuego2_Load(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Maze.kDimension = 10;
            cantDeCeldas = 0;
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
            celdaMovil = TheMaze.inicio;

            //si el laberinto esta generado va a hacer true
            generado = true;

            //genera tiempo
            generarTiempo();
            timer1.Enabled = true;
            timer2.Enabled = true;
            recorrido= TheMaze.recorrerProfundidad(TheMaze.inicio,TheMaze.fin,g2);//recorrido en profundidad devuelve una list
            TiempoRecorrido.Start();// tiempo recorrido de computer
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
          
           
          
            if (generado == true)
            {

               
                switch (keyData)
                {

                    case Keys.Up:
                        if (celdaMovil.Walls[0] == 0)
                        {
                            actualizarDibujo();
                            celdaMovil.coleccionPuntos[0].Y= TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].Y-=20;//resta cuando se dirige hacia arriba
                            celdaMovil = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column - 1];//le asigno la posicion actual a la celdaMovil
                            g1.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);

                        }
                        break;
                    case Keys.Down:
                        if (celdaMovil.Walls[2] == 0)
                        {
                            actualizarDibujo();
                            celdaMovil.coleccionPuntos[0].Y = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].Y += 20;
                           //Suma Y cuando se dirige hacia abajo
                            celdaMovil = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column + 1];//le asigno la posicion actual a la celdaMovil

                            g1.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);
                        }
                        break;
                    case Keys.Left:
                        if (celdaMovil.Walls[1] == 0)
                        {
                            actualizarDibujo();
                            celdaMovil.coleccionPuntos[0].X = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X -= 20;
                            //TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X -= 20;
                            celdaMovil = TheMaze.Cells[celdaMovil.Row - 1, celdaMovil.Column];//le asigno la posicion actual a la celdaMovil

                            g1.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);
                        }
                        break;
                    case Keys.Right:
                        if (celdaMovil.Walls[3] == 0)
                        {
                            actualizarDibujo();
                            celdaMovil.coleccionPuntos[0].X = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X += 20;
                            //TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X += 20;
                            celdaMovil = TheMaze.Cells[celdaMovil.Row + 1, celdaMovil.Column];//le asigno la posicion actual a la celdaMovil

                            g1.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);
                        }
                        break;

                    default:
                        return base.ProcessCmdKey(ref msg, keyData);
                      
                }
              
                if (TheMaze.fin.Column  == celdaMovil.Column && TheMaze.fin.Row == celdaMovil.Row)
                {
                    lblTiempo1.Enabled = false;
                  
                    if (timer1.Enabled == false && timer2.Enabled == false)
                    {
                        MessageBox.Show(compararTiempo());
                        this.Close();
                    }
                   
                 
                }
              
                return true;
               
            }
            return false;
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
            else {
                
                timer1.Stop();
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


            }
            else {

                timer2.Stop();
            }
          
        }

        public string compararTiempo() {
            int tiempo;
            TimeSpan intervalo1= new TimeSpan(tiempo1.Hora, tiempo1.Min, tiempo1.Seg);
            TimeSpan intervalo2= new TimeSpan(tiempo2.Hora, tiempo2.Min, tiempo2.Seg);
            tiempo=TimeSpan.Compare(intervalo1,intervalo2);
            //si son iguales devuelve un 0
            if (tiempo==0)
            {
                return "Hay un empate \n" + "player 1 : " + intervalo1 + "\n computer : " + intervalo2;
            }
            //si el intervalo1 es menor que el intervalo2 devuelve un -1
            else if (tiempo < 0)
            {
                return "haz ganado \n "+ "jugador1 : " + intervalo1 + "\n computer : " + intervalo2;
            }
            //si el intervalo1 es mayor que el intervalo2 devuelve un 1
            else 
            {
                return "haz perdido "+ "jugador1 : " + intervalo1 + "\n computer : " + intervalo2;
            }
        }


        public void actualizarDibujo() {
            int tamaño=20;
            Pen lapiz = Pens.Red;
            g1.Clear(Color.White);
            TheMaze.Draw(g1);
            g1.DrawRectangle(lapiz, TheMaze.inicio.coleccionPuntos[0].X, TheMaze.inicio.coleccionPuntos[0].Y, tamaño, tamaño);
            g1.DrawRectangle(lapiz, TheMaze.fin.coleccionPuntos[0].X, TheMaze.fin.coleccionPuntos[0].Y, tamaño, tamaño);
        }
        
        private void TiempoRecorrido_Tick(object sender, EventArgs e)
        {
        
            if (cantDeCeldas <= recorrido.Count-1)
            {
                g2.FillRectangle(Brushes.Gold, recorrido[cantDeCeldas].coleccionPuntos[0].X + 2.5f, recorrido[cantDeCeldas].coleccionPuntos[0].Y + 2.5f, tamañoCeldaD, tamañoCeldaD);

                cantDeCeldas++;
            }
            else {
                lblTiempo2.Enabled = false;//se deshabilita el label donde muestra el tiempo
                if (lblTiempo1.Enabled == false && lblTiempo2.Enabled == false)
                {
                    TiempoRecorrido.Stop();
                    MessageBox.Show(compararTiempo());
                    this.Close();
                    
                }
              
            }


        }

        private void ModoDeJuego2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //si cierra la ventana se tiene que parar el timer
            TiempoRecorrido.Stop();
        }

        
       
       
        
    }
}
