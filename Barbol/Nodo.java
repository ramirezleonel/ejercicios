package aplicacion.arbol.Barbol;

import com.sun.org.apache.bcel.internal.generic.INSTANCEOF;

public class Nodo {
   private Nodo izq;
   private Nodo der;
   private int dato;
   private static int numDeNodo=0;
   private int numNodo=0;

    public int getNumNodo() {
        return numNodo;
    }

    public void setNumNodo(int numNodo) {
        this.numNodo = numNodo;
    }
  
    public int getNumDeNodo() {
        return numDeNodo;
    }

   

    @Override
    public String toString() {
        return dato + " ";
    }

    public Nodo(int dato) {
        this.dato = dato;
        this.izq=null;
        this.der=null;
       
        numDeNodo++;
        setNumNodo(numDeNodo);
    }

    public Nodo getIzq() {
        return izq;
    }

    public void setIzq(Nodo izq) {
        this.izq = izq;
    }

    public Nodo getDer() {
        return der;
    }

    public void setDer(Nodo der) {
        this.der = der;
    }

    public int getDato() {
        return dato;
    }

    public void setDato(int dato) {
        this.dato = dato;
    }
}
