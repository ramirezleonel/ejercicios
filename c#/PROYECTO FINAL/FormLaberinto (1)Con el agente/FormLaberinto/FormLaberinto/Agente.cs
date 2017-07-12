using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows.Media;
using System.Threading;
using System.ComponentModel;
using System.Windows;
using IAgent;

namespace WpfApp1
{
    class Agente : ISolverAgent
    {

        private Stack<Point> Recorrido { get; set; }

        private List<Point> CeldasVisitadas { get; set; }

        private Point end;

        public Agente(Point start)
        {
            Recorrido = new Stack<Point>();
            Recorrido.Push(start);
            
            CeldasVisitadas = new List<Point>();
            CeldasVisitadas.Add(start);
        }

        //Algortmo de resolucion del laberinto
        public Point moveAgent(params Point[] directions) {
            if(Recorrido.Count == 1)
            {
                    Recorrido.Push(directions[0]);
                    CeldasVisitadas.Add(directions[0]);
                    return directions[0];
                
            } else
            {
                foreach(Point punto in directions)
                {
                    //si la lista no contiene al punto lo agrega
                    if (!CeldasVisitadas.Contains(punto)) {
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
