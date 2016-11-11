package aplicacion.arbol.Barbol;

import aplicacion.arbol.*;
import java.util.LinkedList;
import java.util.Queue;

public class ArbolBinario {
    
    public static int cantDeElemento(Nodo raiz) {
        int num = 0;
        Queue<Nodo> cola = new LinkedList<Nodo>();
        if (raiz != null) {
            cola.add(raiz);
            num++;
            while (!cola.isEmpty()) {
                Nodo aux = cola.poll();
                num++;
                if (aux.getIzq() != null) {
                    cola.add(aux.getIzq());
                }
                if (aux.getIzq() != null) {
                    cola.add(aux.getDer());
                }
            }
            return num;
        }
        return num;
    }

    public static boolean estaEn(int buscarValor, Nodo raiz) {
        if (raiz != null) {
            if (buscarValor == raiz.getDato()) {
                return true;
            }
            boolean a = estaEn(buscarValor, raiz.getIzq());
            boolean b = estaEn(buscarValor, raiz.getDer());
            if (a == true || b == true) {
                return true;
            } else {
                return false;
            }

        }

        return false;

    }

    public static void recorrerAmplitud(Nodo raiz) {
        Queue<Nodo> cola = new LinkedList<Nodo>();
        if (raiz != null) {

            cola.add(raiz);
            while (!cola.isEmpty()) {
                Nodo aux = cola.poll();
                System.out.println(aux);
                if (aux.getIzq() != null) {
                    cola.add(aux.getIzq());
                }
                if (aux.getDer() != null) {
                    cola.add(aux.getDer());
                }
            }
        }
    }

    public static void recorrerPreorden(Nodo raiz) {
        if (raiz == null) {
            return;
        }
        recorrerPreorden(raiz.getIzq());
        System.out.println(raiz);
        recorrerPreorden(raiz.getDer());
    }

    public static void recorrerInorden(Nodo raiz) {
        if (raiz == null) {
            return;
        }
        System.out.println(raiz);
        recorrerInorden(raiz.getIzq());
        recorrerInorden(raiz.getDer());
    }

    public static void recorrerPostOrden(Nodo raiz) {
        if (raiz == null) {
            return;
        }
        recorrerPostOrden(raiz.getIzq());
        recorrerPostOrden(raiz.getDer());
        System.out.println(raiz);
    }

    public static void main(String[] args) {

        Nodo raiz = new Nodo(4);
        Nodo nodo1 = new Nodo(2);
        Nodo nodo2 = new Nodo(5);
        Nodo nodo3 = new Nodo(1);
        Nodo nodo4 = new Nodo(3);
        Nodo nodo5 = new Nodo(6);
        raiz.setIzq(nodo1);
        raiz.setDer(nodo2);
        nodo1.setIzq(nodo3);
        nodo1.setDer(nodo4);
        nodo2.setDer(nodo5);

        recorrerPreorden(raiz);
        System.out.println("---------------------------");
        recorrerInorden(raiz);
        System.out.println("---------------------------");
        recorrerPostOrden(raiz);
        System.out.println("---------------------------");
        recorrerAmplitud(raiz);
        System.out.println("...........................");
        System.out.println(estaEn(7, raiz));
        System.out.println("...........................");
        System.out.println(cantDeElemento(raiz));
        System.out.println(nodo4.getNumNodo());
    }
}
