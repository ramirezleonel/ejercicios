package PaqueteNuevo;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class Grafo {
 public static Stack<Aristas> caminoRecorrido = new Stack<Aristas>();
    public static void caminoMasCorto(Nodo primero, Nodo ultimo) {
        LinkedList<Aristas> listaAristas = new LinkedList<Aristas>();
        
        listaAristas.addAll(primero.listaAristas);
        Nodo aux = primero;

        Aristas aux1;

        while (!listaAristas.isEmpty()) {
            Aristas aux2 = null;
            if (!aux.getName().equals(ultimo.getName())) {

                for (Aristas a : listaAristas) {
                    if (aux2 == null) {
                        aux2 = listaAristas.get(0);
                    }
                    if (a.getCosto() <= aux2.getCosto()) {

                        aux2 = a;

                    }
                }
                listaAristas.removeAll(listaAristas);
                caminoRecorrido.add(aux2);
                listaAristas.addAll(aux2.getUltimo().listaAristas);
                if (listaAristas.contains(aux2)) {
                    listaAristas.remove(aux2);
                }
                aux = aux2.getUltimo();
            }else{
            listaAristas.removeAll(listaAristas);
            }
        }

    }

    public static void main(String[] args) {
        Nodo nodoA = new Nodo("A");
        Nodo nodoB = new Nodo("B");
        Nodo nodoC = new Nodo("C");
        Nodo nodoD = new Nodo("D");
        Nodo nodoE = new Nodo("E");
        Nodo nodoF = new Nodo("F");
        Nodo nodoG = new Nodo("G");
        Nodo nodoH = new Nodo("H");
        Nodo nodoI = new Nodo("I");
        Nodo nodoJ = new Nodo("J");
        Aristas arista1 = new Aristas(1, nodoA, nodoB);
        Aristas arista2 = new Aristas(2, nodoA, nodoC);
        Aristas arista3 = new Aristas(3, nodoA, nodoD);
        Aristas arista4 = new Aristas(4, nodoB, nodoE);
        Aristas arista5 = new Aristas(5, nodoB, nodoF);
        Aristas arista6 = new Aristas(6, nodoC, nodoG);
        Aristas arista7 = new Aristas(7, nodoD, nodoH);
        Aristas arista8 = new Aristas(8, nodoD, nodoI);
        Aristas arista9 = new Aristas(9, nodoI, nodoJ);
        Aristas arista10 = new Aristas(10, nodoH, nodoJ);
        Aristas arista11 = new Aristas(11, nodoG, nodoJ);
        Aristas arista12 = new Aristas(12, nodoF, nodoJ);
        Aristas arista13 = new Aristas(13, nodoE, nodoJ);
        caminoMasCorto(nodoA, nodoJ);
        System.out.println(caminoRecorrido);
    }
}
