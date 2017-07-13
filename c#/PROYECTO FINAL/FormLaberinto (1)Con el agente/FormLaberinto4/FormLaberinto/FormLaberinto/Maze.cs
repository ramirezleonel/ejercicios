using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace FormLaberinto
{
    /// <summary>
    /// Summary description for Maze.
    /// </summary>
    public class Maze
    {
        public static int kDimension = 10;
        public Cell[,] Cells;
        Stack CellStack = new Stack();
        int VisitedCells = 1;
        int TotalCells = kDimension * kDimension;
        Cell CurrentCell = null;
        Random random;
        public Cell inicio;
        public Cell fin;


        public Maze()
        {
            //
            // TODO: Add constructor logic here
            //
            Initialize();
        }

        private ArrayList GetNeighborsWithWalls(Cell aCell)
        {
            ArrayList Neighbors = new ArrayList();
            //otro arraylist con los vecinos

            for (int countRow = -1; countRow <= 1; countRow++)
                for (int countCol = -1; countCol <= 1; countCol++)
                {
                    if ((aCell.Row + countRow < kDimension) &&
                         (aCell.Column + countCol < kDimension) &&
                         (aCell.Row + countRow >= 0) &&
                         (aCell.Column + countCol >= 0) &&
                         ((countCol == 0) || (countRow == 0)) &&
                         (countRow != countCol)
                        )
                    {
                        if (Cells[aCell.Row + countRow, aCell.Column + countCol].HasAllWalls())
                        {
                            Neighbors.Add(Cells[aCell.Row + countRow, aCell.Column + countCol]);
                            //agrega todos los vecinos que tienen todas las paredes
                        }
                    }
                }

            return Neighbors;
        }

        public void Initialize()
        {
            Cells = new Cell[kDimension, kDimension];
            TotalCells = kDimension * kDimension;
            //inicializo las celdas con su propiedades row y column
            for (int i = 0; i < kDimension; i++)
                for (int j = 0; j < kDimension; j++)
                {
                    Cells[i, j] = new Cell();
                    Cells[i, j].Row = i;
                    Cells[i, j].Column = j;
                    Cells[i, j].punto.X = i;
                    Cells[i, j].punto.Y = j;

                }

            CurrentCell = Cells[0, 0];
            VisitedCells = 1;
            //limpia la pila de celdas por visitar
            CellStack.Clear();
        }

        public void Generate()
        {
            while (VisitedCells < TotalCells)
            {
                // devuelve todos los vecinos de la celda actual dentro de los limites

                ArrayList AdjacentCells = GetNeighborsWithWalls(CurrentCell);
                // test if a cell like this exists
                if (AdjacentCells.Count > 0)
                {
                    //  elige uno de ellos, y derribar la pared entre el ramdom y la celda actual
                    int randomCell = Cell.TheRandom.Next(0, AdjacentCells.Count);
                    Cell theCell = ((Cell)AdjacentCells[randomCell]);
                    CurrentCell.KnockDownWall(theCell);//derriba la pared
                    CellStack.Push(CurrentCell); // push the current cell onto the stack
                    CurrentCell = theCell; // make the random neighbor the new current cell
                    VisitedCells++;
                }
                else
                {
                    // No cells with walls intact, pop current cell from stack
                    CurrentCell = (Cell)CellStack.Pop();
                }

            }
        }



        public void encontrarInicioFin(Graphics g)
        {

            int tamañoCelda = Cell.kCellSize - 1;
            random = new Random();
            int aleatorio;
            Pen lapiz = Pens.Red;

            aleatorio = this.random.Next(0, kDimension - 1);
            inicio = Cells[0, aleatorio];
            //coleccionPuntos[0]= esquina superior izq
            g.DrawRectangle(lapiz, Cells[0, aleatorio].coleccionPuntos[0].X, Cells[0, aleatorio].coleccionPuntos[0].Y, tamañoCelda, tamañoCelda);
            aleatorio = this.random.Next(0, kDimension - 1);

            fin = Cells[kDimension - 1, aleatorio];
            //coleccionPuntos[2]= esquina superior derecha
            g.DrawRectangle(lapiz, Cells[kDimension - 1, aleatorio].coleccionPuntos[0].X, Cells[kDimension - 1, aleatorio].coleccionPuntos[0].Y, tamañoCelda, tamañoCelda);
        }

        public List<System.Windows.Point> recorrerProfundidad()
        {
            Agente agente = new Agente(inicio.punto);

            System.Windows.Point[] direcciones;
            System.Windows.Point puntoAux = inicio.punto;


            List<System.Windows.Point> visitados = new List<System.Windows.Point>();//lista de las celdas visitadas hasta llegar al final
            //agrego el punto inicio a la lista visitados
            visitados.Add(inicio.punto);
            //le sumo 1 a la y de la celda fin para que coincida con el dibujo
            //fin.punto.Y++;

            bool noLlego = true;
            while (noLlego)
            {
                direcciones = getVecinos(puntoAux);//getvecinos devuelve un arreglo de puntos apartir de puntoAux para poder pasarle al agente
                puntoAux = agente.moveAgent(direcciones);//el agente se mueve y me devuelve un punto

                if (!visitados.Contains(puntoAux))
                {
                    visitados.Add(puntoAux);
                }

                if (puntoAux == fin.punto)
                {
                    //si llego al final retorna la lista de visitados
                    noLlego = false;
                }
            }

            return visitados;

        }

        public System.Windows.Point[] getVecinos(System.Windows.Point punto)
        {

            int i = 0;
            int ran = 0;
            System.Windows.Point[] aux;

            List<Cell> vecinos = new List<Cell>();//creo una lista para usarlo como auxiliar y retornarlo

            //revisa la celda superior,con respecto a la celda actual dentro de las dimensiones del laberinto
            if ((int)punto.Y - 1 >= 0)
            {
                //si la linea horizontal superior esta derribado
                if (Cells[(int)punto.X, (int)punto.Y].Walls[0] == 0)
                {
                    //agrego en la lista de vecinos la celda derecha con respecto a celdaActual
                    vecinos.Add(Cells[(int)punto.X, (int)punto.Y - 1]);

                }

            }

            //revisa la celda izquierda,dentro de las dimensiones del laberinto
            if ((int)punto.X - 1 >= 0)
            {
                //si la linea vertical izquierda con respecto a la celda actual,esta derribado
                if (Cells[(int)punto.X, (int)punto.Y].Walls[1] == 0)
                {
                    //agrego en la lista de vecinos la celda izquierda con respecto a celdaActual
                    vecinos.Add(Cells[(int)punto.X - 1, (int)punto.Y]);

                }

            }
            //revisa la celda inferior, con respecto a la celda actual dentro de las dimensiones del laberinto
            if ((int)punto.Y + 1 <= kDimension - 1)
            {
                //si la linea inferior horizontal esta derribado
                if (Cells[(int)punto.X, (int)punto.Y].Walls[2] == 0)
                {
                    //agrego en la lista de vecinos la celda derecha con respecto a celdaActual
                    vecinos.Add(Cells[(int)punto.X, (int)punto.Y + 1]);

                }

            }

            //revisa la celda derecha,dentro de las dimensiones del laberinto
            if ((int)punto.X + 1 <= kDimension - 1)
            {
                //si la linea vertical derecha con respecto a la celda actual esta derribado
                if (Cells[(int)punto.X, (int)punto.Y].Walls[3] == 0)
                {
                    //agrego en la lista de vecinos la celda derecha con respecto a celdaActual
                    vecinos.Add(Cells[(int)punto.X + 1, (int)punto.Y]);

                }

            }

            aux = new System.Windows.Point[vecinos.Count];//le paso aux la longitud de la lista 
            while (vecinos.Count > 0)
            {
                ran = Cell.TheRandom.Next(0, vecinos.Count);
                aux[i] = vecinos[ran].punto;//devuelve puntos
                vecinos.RemoveAt(ran);
                i++;//i es una variable local
            }
            return aux;
        }
        public void asignarMismoLaberinto(Maze copia)
        {

            for (int i = 0; i < kDimension; i++)
            {
                for (int j = 0; j < kDimension; j++)
                {
                    copia.Cells[i, j].coleccionPuntos = Cells[i, j].coleccionPuntos;
                    copia.Cells[i, j].Walls = Cells[i, j].Walls;

                    Cells[i, j].Row = i;
                    Cells[i, j].Column = j;
                    Cells[i, j].punto.X = i;
                    Cells[i, j].punto.Y = j;
                }
            }


        }
        public void Draw(Graphics g)
        {
            //construye las celdas segun su posicion
            for (int i = 0; i < kDimension; i++)
                for (int j = 0; j < kDimension; j++)
                {
                    Cells[i, j].Draw(g);
                }
        }
    }
}

