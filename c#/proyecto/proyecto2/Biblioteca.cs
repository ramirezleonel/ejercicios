using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Biblioteca
    {
        private ArrayList Libros = new ArrayList();
        public ArrayList libros { get; set; }


        public void agregarLibros(Libro nuevo) {

            this.Libros.Add(nuevo) ;
        
        }

              
         }
    
}
