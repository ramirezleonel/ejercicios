package aplicacion.otro;

import java.util.LinkedList;

public class Grafo {
    public static void main(String[] args) {
       Nodo nodoA=new Nodo("A");
       Nodo nodoB=new Nodo("B");
       Nodo nodoC=new Nodo("C");
       Nodo nodoD=new Nodo("D");
       Nodo nodoE=new Nodo("E");
       Nodo nodoF=new Nodo("F");
        nodoA.agregarVecinos(nodoB);
        nodoA.agregarVecinos(nodoC);
        nodoA.agregarVecinos(nodoD);
        nodoB.agregarVecinos(nodoE);
        nodoC.agregarVecinos(nodoE);
        nodoC.agregarVecinos(nodoF);
        Recorrido r=new Recorrido();

      //r.recorridoProfundidad(nodoA);
       r.BFS(nodoA);
        
        
        
      
        
    }
}
