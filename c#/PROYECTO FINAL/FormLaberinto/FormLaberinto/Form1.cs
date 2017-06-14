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
    public partial class Form1 : Form
    {
     
        private Maze TheMaze = new Maze();
        public Form1()
        {


            TheMaze.Generate();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Graphics g = this.CreateGraphics();
            
            g.FillRectangle(Brushes.White, ClientRectangle);
          
            TheMaze.Draw(g);


            //dimensiones del laberinto ya resuelto
            Maze.kDimension = 30;
            Cell.kCellSize = 10;
            
            TheMaze.Initialize();
            TheMaze.Generate();
            g.Dispose();
            
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
