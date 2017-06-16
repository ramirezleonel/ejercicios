using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormLaberinto
{

	/// <summary>
	/// Summary description for Cell.
	/// </summary>
	public class Cell
	{
		public static int kCellSize = 10;
		public static int kPadding = 20;//la distancia con respecto al form
		public int[] Walls  = new int[4]{1, 1, 1, 1};
        

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
        //tiene todas las paredes
		public bool HasAllWalls()
		{
			for (int i = 0; i < 4; i++)
			{
				 if (Walls[i] == 0)
					 return false;
			}

			return true;
		}

		public void KnockDownWall(int theWall)
		{
			Walls[theWall] = 0;
		}

		public void KnockDownWall(Cell theCell)
		{
			// find adjacent wall
			int theWallToKnockDown = FindAdjacentWall(theCell);
			Walls[theWallToKnockDown] = 0;
			int oppositeWall = (theWallToKnockDown + 2) % 4;
			theCell.Walls[oppositeWall] = 0;

		}


		public  int FindAdjacentWall(Cell theCell)
		{
			if (theCell.Row == Row) 
			{
				if (theCell.Column < Column)
					return 0;
				else
					return 2;
			}
			else // columns are the same
			{
				if (theCell.Row < Row)
					return 1;
				else
					return 3;
			}
		}

		public int GetRandomWall()
		{
			int nextWall = TheRandom.Next(0, 3);
			while ( (Walls[nextWall] == 0)  
			||		((Row == 0) && (nextWall == 0)) ||
					((Row == Maze.kDimension - 1) && (nextWall == 2)) ||
					((Column == 0) && (nextWall == 1)) ||
					((Column == Maze.kDimension - 1) && (nextWall == 3)) 
				   )
			{
				nextWall = TheRandom.Next(0, 3);
			}

			return nextWall;
		}

		public void Draw(Graphics g)
		{
            coleccionPuntos=new Point[4];
            coleccionPuntos[0].X= Row*kCellSize + kPadding;//punto esquina superior izq
            coleccionPuntos[0].Y = Column * kCellSize + kPadding;
            coleccionPuntos[1].X = (Row + 1) * kCellSize + kPadding;//punto esquina inferior izq
            coleccionPuntos[1].Y = Column * kCellSize +kPadding;
            coleccionPuntos[2].X = Row * kCellSize + kPadding;//punto esquina superior der
            coleccionPuntos[2].Y = (Column + 1) * kCellSize + kPadding;
            coleccionPuntos[3].X=(Row+1)*kCellSize + kPadding;
            coleccionPuntos[3].Y = (Column + 1) * kCellSize + kPadding;//punto esquina inferior der
			if (Walls[0] == 1)
			{
                                
                //drawline (lapiz,float cordenada1x,cordenada1y,cordenada2x,cordenada2y)
                //padding relleno 
                //padding es la distancia que hay con respecto al form
				g.DrawLine(Pens.Blue, Row*kCellSize + kPadding, Column*kCellSize + kPadding, (Row+1) * kCellSize   + kPadding, Column*kCellSize +  + kPadding);
			//linea vertical izq
            }
			if (Walls[1] == 1)
			{
				g.DrawLine(Pens.Blue, Row*kCellSize  + kPadding, Column*kCellSize + kPadding, Row*kCellSize + kPadding, (Column+1)*kCellSize + kPadding);
                //linea horizontal superior
            }
			if (Walls[2] == 1)
			{
				g.DrawLine(Pens.Blue, Row*kCellSize + kPadding, (Column+1)*kCellSize + kPadding, (Row+1)*kCellSize + kPadding, (Column+1)*kCellSize + kPadding);
                //linea vertical der
            }
			if (Walls[3] == 1)
			{
			
                g.DrawLine(Pens.Blue,(Row+1)*kCellSize + kPadding , Column*kCellSize + kPadding, (Row+1)*kCellSize + kPadding, (Column+1)*kCellSize + kPadding);
                //linea horizontal inferior
            }



		}
	}
}
