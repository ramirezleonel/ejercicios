using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using IAgent;
namespace FormLaberinto
{
    class Agente : ISolverAgent
    {

        private Stack<Point> PilaDePuntos { get; set; }

        public List<Point> CeldasRecorridas { get; set; }

        public Agente(Point celdaIni)
        {
            CeldasRecorridas = new List<Point>();

            PilaDePuntos = new Stack<Point>();

            CeldasRecorridas.Add(celdaIni);

            PilaDePuntos.Push(celdaIni);

           
        }



        public Point moveAgent(params Point[] directions)
        {
            if (directions.Length != 0)
            {
                foreach (Point punto in directions)
                {
                    //si la lista no contiene al punto lo agrega
                    if (!CeldasRecorridas.Contains(punto))
                    {
                        CeldasRecorridas.Add(punto);
                        PilaDePuntos.Push(punto);
                        return punto;
                    }
                }
                PilaDePuntos.Pop();
                foreach (Point punto in directions)
                {
                    if (punto.Equals(PilaDePuntos.Peek()))
                    {
                        return punto;
                    }
                }

            }
            return PilaDePuntos.Pop();
        }
    }
}

