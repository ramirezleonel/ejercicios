using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLaberinto
{
    public class Tiempo
    {
        private int hora;
        public int Hora{
            
            set
            {
                if (value >=0&&value<=24) {
                    this.hora = value;
                }
                    }
            get { return hora; }
        }
        private int min;
        public int Min
        {
            get { return min; }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    this.min= value;
                }
            }
        }
        private int seg;
        public int Seg
        {
            get { return seg; }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    this.seg = value;
                }
            }
        }
        public Tiempo(int hora,int min,int seg) {
            this.Hora = hora;
            this.Min = min;
            this.Seg = seg;
        
        
        }
        public override string ToString()
        {
            return Hora.ToString().PadLeft(2, '0') + ":" + Min.ToString().PadLeft(2, '0') + ":" + Seg.ToString().PadLeft(2, '0');
        }
    }

}
