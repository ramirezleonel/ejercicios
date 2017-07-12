using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FormLaberinto
{

	/// <summary>
	/// Summary description for Cell.
	/// </summary>
	public class Cell
	{
        public bool visitada { get; set; }
		public static int kCellSize = 20;
		public static int kPadding = 20;//la distancia con respecto al form
        /// <summary>
        /// pos0=linea horizontal superior
        /// pos1=linea vertical izquierda\
        /// pos2=linea horizontal inferior\
        /// pos3=linea vertical derecha\
        /// </summary>
        public int[] Walls = new int[4] { 1, 1, 1, 1 };
        
        public System.Windows.Point punto;//ubicacion de puntos
		public int Row;
		public int Column;
		private static long Seed = 	DateTime.Now.Ticks;//se usa unicamente para el random
		static public Random TheRandom = new Random((int)Cell.Seed);

        public Point[] coleccionPuntos;
		public Cell()
		{
			//
			// TODO: Add constructor logic here
			//
		}
        //tiene todas las paredes retorna true
		public bool HasAllWalls()
		{
			for (int i = 0; i < 4; i++)
			{
				 if (Walls[i] == 0)
					 return false;
			}

			return true;
		}

		public void KnockDownWallfafab(int theWall)
		{
			Walls[theWall] = 0;
		}

		public void KnockDownWall(Cell theCell)
		{
            
			// encuentra su adyacente
			int theWallToKnockDown = FindAdjacentWall(theCell);
			Walls[theWallToKnockDown] = 0;//le paso la pared que quiero derribar
			int oppositeWall = (theWallToKnockDown + 2) % 4;//devuelve el resto de la pared a derribar +2 /4
			theCell.Walls[oppositeWall] = 0;

		}


		public  int FindAdjacentWall(Cell theCell)
		{
            //encuentra su adyacente
            // esta en la misma fila
			if (theCell.Row == Row) 
			{
				if (theCell.Column < Column)
					return 0;
				else
					return 2;
			}
			else // esta en la misma columna
			{
				if (theCell.Row < Row)
					return 1;
				else
					return 3;
			}
		}

		

		public void Draw(Graphics g)
		{
            Pen lapiz = new Pen(Color.Blue, 5);
            coleccionPuntos=new Point[4];
            coleccionPuntos[0].X= Row*kCellSize + kPadding;//punto esquina superior izq
            coleccionPuntos[0].Y = Column * kCellSize + kPadding;
            coleccionPuntos[1].X = (Row + 1) * kCellSize + kPadding;//punto esquina superior der
            coleccionPuntos[1].Y = Column * kCellSize +kPadding;
            coleccionPuntos[2].X = Row * kCellSize + kPadding;//punto esquina inferior izq
            coleccionPuntos[2].Y = (Column + 1) * kCellSize + kPadding;
            coleccionPuntos[3].X=(Row+1)*kCellSize + kPadding;
            coleccionPuntos[3].Y = (Column + 1) * kCellSize + kPadding;//punto esquina inferior der
			if (Walls[0] == 1)
			{
                                
                //drawline (lapiz,float cordenada1x,cordenada1y,cordenada2x,cordenada2y)
                //padding relleno 
                //padding es la distancia que hay con respecto al form
				g.DrawLine(lapiz, Row*kCellSize + kPadding, Column*kCellSize + kPadding, (Row+1) * kCellSize   + kPadding, Column*kCellSize +  + kPadding);
			//linea horizontal superior
            }
			if (Walls[1] == 1)
			{
				g.DrawLine(lapiz, Row*kCellSize  + kPadding, Column*kCellSize + kPadding, Row*kCellSize + kPadding, (Column+1)*kCellSize + kPadding);
                //linea vertical izquierda
            }
			if (Walls[2] == 1)
			{
				g.DrawLine(lapiz, Row*kCellSize + kPadding, (Column+1)*kCellSize + kPadding, (Row+1)*kCellSize + kPadding, (Column+1)*kCellSize + kPadding);
                //linea horizontal inferior 
            }
			if (Walls[3] == 1)
			{
			
                g.DrawLine(lapiz,(Row+1)*kCellSize + kPadding , Column*kCellSize + kPadding, (Row+1)*kCellSize + kPadding, (Column+1)*kCellSize + kPadding);
                //linea vertical derecha
            }



		}

        public bool isVisitado()
        {
            return visitada;
        }

      
    }
}
