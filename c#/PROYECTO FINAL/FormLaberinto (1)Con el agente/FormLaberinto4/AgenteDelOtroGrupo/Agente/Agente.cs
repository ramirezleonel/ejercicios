using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using IAgent;
using System.Windows;

namespace Agente
{
    public class Agente: ISolverAgent
    {
        private Stack<Point> Camino { get; set; }

        private List<Point> CeldasMarcadas { get; set; }

        private Point end;

        public Agente(Point start)
        {
            Camino = new Stack<Point>();
            Camino.Push(start); 

            CeldasMarcadas = new List<Point>();
            CeldasMarcadas.Add(start);
        }

        //Algortmo de resolucion del laberinto
        public Point moveAgent(params Point[] directions)
        {
            if (Camino.Count == 1)
            {
                Camino.Push(directions[0]);
                CeldasMarcadas.Add(directions[0]);
                return directions[0];

            }
            else
            {
                foreach (Point point in directions)
                {
                    if (!CeldasMarcadas.Contains(point))
                    {
                        CeldasMarcadas.Add(point);
                        Camino.Push(point);
                        return point;
                    }
                }
                Camino.Pop();
                foreach (Point punto in directions)
                {
                    if (punto.Equals(Camino.Peek()))
                    {
                        return punto;
                    }
                }

                return end;
            }
        }

        System.Windows.Point ISolverAgent.moveAgent(params System.Windows.Point[] directions)
        {
            throw new NotImplementedException();
        }
    }
}
