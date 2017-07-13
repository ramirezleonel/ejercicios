using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FormLaberinto
{
    public partial class Form1 : Form
    {

        Graphics g;

        Tiempo tiempo;
        public bool generado;
        private Cell celdaMovil;
        private Maze TheMaze;
        public Form1()
        {
            
            //creo el laberinto
            TheMaze = new Maze();
            //es falso cuando recien inicia el form
            generado = false;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maze.kDimension = int.Parse(cbDimensiones.Text);
       
            TheMaze.Initialize();
            //TheMaze.Generate();
            g = pictureBox1.CreateGraphics();
            g.FillRectangle(Brushes.White, ClientRectangle);
            //dimensiones del laberinto ya resuelto
            TheMaze.Generate();
            TheMaze.Draw(g);
            //encuentra el punto de inicio y fin de forma aleatoria
            TheMaze.encontrarInicioFin(g);
            celdaMovil = TheMaze.inicio;
          
            //si el laberinto esta generado va a hacer true
            generado = true;

            //genera tiempo
            generarTiempo();
            timer1.Enabled = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           Pen lapiz;
           Cell celdaAux;
            
            int tamañoCelda = Cell.kCellSize-5;
           if(generado==true){

               //if (isDibujo)
               //{
                   
               //    g.FillRectangle(Brushes.White, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCelda, tamañoCelda);
               //}
     
            lapiz = Pens.Green;
            switch (keyData)
            {
                case Keys.Up:
                    if(celdaMovil.Walls[0]==0){
                       
                        TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].Y -= 20;//resta cuando se dirige hacia arriba
                        celdaMovil= TheMaze.Cells[celdaMovil.Row, celdaMovil.Column-1];//le asigno la posicion actual a la celdaMovil
                        g.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f , celdaMovil.coleccionPuntos[0].Y + 2.5f,tamañoCelda,tamañoCelda);
                        celdaAux = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column + 1];
                       
                    }
                    break;
                case Keys.Down:
                    if (celdaMovil.Walls[2] == 0) {
                       
                        TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].Y += 20;//Suma Y cuando se dirige hacia abajo
                        celdaMovil = TheMaze.Cells[celdaMovil.Row, celdaMovil.Column + 1];//le asigno la posicion actual a la celdaMovil

                        g.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCelda, tamañoCelda);
                    }
                    break;
                case Keys.Left:
                    if (celdaMovil.Walls[1] == 0)
                    {
                       
                        TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X -= 20;
                        celdaMovil = TheMaze.Cells[celdaMovil.Row-1, celdaMovil.Column];//le asigno la posicion actual a la celdaMovil

                        g.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCelda, tamañoCelda);
                    }
                    break;
                case Keys.Right:
                    if (celdaMovil.Walls[3] == 0)
                    {
                       
                        TheMaze.Cells[celdaMovil.Row, celdaMovil.Column].coleccionPuntos[0].X += 20;
                        celdaMovil = TheMaze.Cells[celdaMovil.Row + 1, celdaMovil.Column];//le asigno la posicion actual a la celdaMovil

                        g.FillRectangle(Brushes.Gold, celdaMovil.coleccionPuntos[0].X + 2.5f, celdaMovil.coleccionPuntos[0].Y + 2.5f, tamañoCelda, tamañoCelda);
                    }
                    break;

                default:
                       return base.ProcessCmdKey(ref msg, keyData);
            }
          
          
           
            if (TheMaze.fin.Column+1 == celdaMovil.Column && TheMaze.fin.Row == celdaMovil.Row) {
                lblTemp.Enabled = false;
                MessageBox.Show("Haz llegado \n"+" tu tiempo es: "+tiempo.Hora.ToString().PadLeft(2,'0')+":"+tiempo.Min.ToString().PadLeft(2,'0')+":"+tiempo.Seg.ToString().PadLeft(2,'0'));
                g.Dispose();
                this.Close();
            }
              
               return true;
           }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {

        }

        private void lblTemp_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (lblTemp.Enabled)
            {

                tiempo.Seg++;
                if (tiempo.Seg == 60)
                {
                    tiempo.Min++;
                    tiempo.Seg = 00;
                }
                if (tiempo.Min == 60)
                {
                    tiempo.Hora++;
                    tiempo.Min = 00;

                }
                lblTemp.Text = tiempo.ToString();
            }

        }
        public void generarTiempo(){
            lblTemp.Enabled = true;
           tiempo = new Tiempo(00, 00, 00);
        
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbDimensiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        
        


    }

}