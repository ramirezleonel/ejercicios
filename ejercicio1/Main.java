package parcial;

import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class Main {
    public static Stack<Nodo>cola=new Stack<Nodo>();
    public static void recorrerPreorden(Nodo raiz) {
        if (raiz == null) {
            return;
        }
        recorrerPreorden(raiz.getIzq());
        cola.add(raiz);
        
        recorrerPreorden(raiz.getDer());
}
	public static void main(String[] args) {
		Nodo raiz=new Nodo("A");
		Nodo nodo1=new Nodo("B");
		Nodo nodo2=new Nodo("C");
		Nodo nodo3=new Nodo("D");
		Nodo nodo4=new Nodo("E");
		Nodo nodo5=new Nodo("F");
		Nodo nodo6=new Nodo("G");
		Nodo nodo7=new Nodo("H");
		Nodo nodo8=new Nodo("I");
		Nodo nodo9=new Nodo("J");
		raiz.setIzq(nodo8);
		raiz.setDer(nodo2);
		nodo2.setIzq(nodo3);
		nodo2.setDer(nodo1);
		nodo3.setIzq(nodo5);
		nodo5.setIzq(nodo6);
		nodo5.setDer(nodo4);
		nodo8.setIzq(nodo9);
		nodo8.setDer(nodo7);
		nodo3.setIzq(nodo4);
		nodo4.setIzq(nodo6);
		nodo4.setDer(nodo4);
		recorrerPreorden(raiz);
		System.out.println(cola);
	}
}
