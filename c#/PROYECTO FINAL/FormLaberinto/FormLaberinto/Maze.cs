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
        public Cell[,] Cells ;
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
                    Cells[i, j].visitada = false;
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
            Pen lapiz=Pens.Red;
            
            aleatorio = this.random.Next(0, kDimension-1);
            inicio = Cells[0, aleatorio];
            //coleccionPuntos[0]= esquina superior izq
                g.DrawRectangle(lapiz, Cells[0, aleatorio].coleccionPuntos[0].X, Cells[0, aleatorio].coleccionPuntos[0].Y, tamañoCelda, tamañoCelda);
                aleatorio = this.random.Next(0, kDimension-1);

                fin = Cells[kDimension-1, aleatorio];
            //coleccionPuntos[2]= esquina superior derecha
                g.DrawRectangle(lapiz, Cells[kDimension-1, aleatorio].coleccionPuntos[2].X, Cells[kDimension-1, aleatorio].coleccionPuntos[2].Y, tamañoCelda, tamañoCelda);
        }

        public List<Cell> recorrerProfundidad(Cell inicio, Cell fin, Graphics g)
        {

            int tamañoCelda = Cell.kCellSize - 5;
            Stack<Cell> pila = new Stack<Cell>();//genero un stack para poder volver al estado anterior
            List<Cell> visitados = new List<Cell>();//lista de las celdas visitadas hasta llegar al final
            pila.Push(inicio);//agrego la celda inicio para empezar a saber sus vecinos
            while (pila.Count != 0)//mientras que la pila no esté vacio
            {
                Cell aux = pila.Pop();
                if (!aux.isVisitado())
                {
                    visitados.Add(aux);//agrego a la lista la celda que quiero conocer sus vecinos
                    aux.visitada = true;
                    // si encontro?? el final??
                    if (aux.Column == fin.Column+1 && aux.Row == fin.Row)
                    {
                        
                        return visitados;//retorno la lista de todos los visitados
                    }
                    
                    foreach (Cell celda in getVecinos(aux))
                    {
                        pila.Push(celda);//agrega sus vecinos que no tengan paredes unidas a ésta
                    }
                }
            }

            return visitados;

        }

        public List<Cell> getVecinos(Cell celdaActual)
        {
            int ran = 0;
            Random random = new Random();
            List<Cell> aux = new List<Cell>();
            List<Cell> vecinos = new List<Cell>();//creo una lista para usarlo como auxiliar y retornarlo

            //revisa la celda izquierda,dentro de las dimensiones del laberinto
            if (celdaActual.Row - 1 >= 0)
            {
                //si la linea vertical izquierda con respecto a la celda actual,esta derribado
                if (Cells[celdaActual.Row, celdaActual.Column].Walls[1] == 0)
                {
                    //agrego en la lista de vecinos la celda izquierda con respecto a celdaActual
                    vecinos.Add(Cells[celdaActual.Row - 1, celdaActual.Column]);

                }

            }
            //revisa la celda derecha,dentro de las dimensiones del laberinto
            if (celdaActual.Row + 1 <= kDimension - 1)
            {
                //si la linea vertical derecha con respecto a la celda actual esta derribado
                if (Cells[celdaActual.Row, celdaActual.Column].Walls[3] == 0)
                {
                    //agrego en la lista de vecinos la celda derecha con respecto a celdaActual
                    vecinos.Add(Cells[celdaActual.Row + 1, celdaActual.Column]);

                }

            }
            //revisa la celda inferior, con respecto a la celda actual dentro de las dimensiones del laberinto
            if (celdaActual.Column + 1 <= kDimension - 1)
            {
                //si la linea vertical derecha esta derribado
                if (Cells[celdaActual.Row, celdaActual.Column].Walls[2] == 0)
                {
                    //agrego en la lista de vecinos la celda derecha con respecto a celdaActual
                    vecinos.Add(Cells[celdaActual.Row, celdaActual.Column + 1]);

                }

            }
            //revisa la celda superior,con respecto a la celda actual dentro de las dimensiones del laberinto
            if (celdaActual.Column - 1 >= 0)
            {
                //si la linea horizontal inferior esta derribado
                if (Cells[celdaActual.Row, celdaActual.Column].Walls[0] == 0)
                {
                    //agrego en la lista de vecinos la celda derecha con respecto a celdaActual
                    vecinos.Add(Cells[celdaActual.Row, celdaActual.Column - 1]);

                }

            }

            while (vecinos.Count > 0)
            {
                ran = random.Next(0, vecinos.Count);
                aux.Add(vecinos[ran]);
                vecinos.RemoveAt(ran);
            }
            return aux;
        }
        public void asignarMismoLaberinto(Maze copia) {

            for (int i = 0; i < kDimension; i++)
            {
                for (int j = 0; j < kDimension; j++)
                {
                    copia.Cells[i, j].coleccionPuntos = Cells[i,j].coleccionPuntos;
                    copia.Cells[i, j].Walls = Cells[i, j].Walls;
                    copia.Cells[i, j].visitada = false ;
                    
                    Cells[i, j].Row = i;
                    Cells[i, j].Column = j;
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
