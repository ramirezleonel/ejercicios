using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Libro:IColeccionable,IComparable
    {
        public string Autor
        {
            get;
            set;
        }
        public string Titulo
        {
            get;
            set;


        }
        public override string ToString()
        {
            return this.describir();
        }
        public Libro(string autor,string titulo){
            this.Autor = autor;
            this.Titulo= titulo;

    }

        public string describir()
        {
            return "El titulo es : " + this.Titulo + " Autor : " + this.Autor;
        }

        public int CompareTo(object obj)
        {
            if(obj!=null){
            Libro lib =(obj as Libro);
            return this.Titulo.CompareTo(lib.Titulo);
            }else{
            return -1;
            }
          
        }
    }
}
