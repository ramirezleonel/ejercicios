using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using IAgent;
namespace FormLaberinto
{
    class Agente1 :ISolverAgent

    {
        private Point end;
        private Stack<Point> Recorrido { get; set; }

        public List<Point> CeldasVisitadas { get; set; }
         
        public Agente1(Point inicio)
        {
            Recorrido = new Stack<Point>();
            Recorrido.Push(inicio);
            
            CeldasVisitadas = new List<Point>();
            CeldasVisitadas.Add(inicio);
        }
        //Algortmo de resolucion del laberinto
        public Point moveAgent(params Point[] directions)
        {
            if (Recorrido.Count == 1)
            {
                Recorrido.Push(directions[0]);
                CeldasVisitadas.Add(directions[0]);
                return directions[0];

            }
            else
            {
                foreach (Point punto in directions)
                {
                    //si la lista no contiene al punto lo agrega
                    if (!CeldasVisitadas.Contains(punto))
                    {
                        CeldasVisitadas.Add(punto);
                        Recorrido.Push(punto);
                        return punto;
                    }
                }
                Recorrido.Pop();
                foreach (Point punto in directions)
                {
                    if (punto.Equals(Recorrido.Peek()))
                    {
                        return punto;
                    }
                }

                return end;
            }
        }
    }
}
