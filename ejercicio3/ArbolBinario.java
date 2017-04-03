package parcial3;

import java.util.LinkedList;
import java.util.Queue;

public class ArbolBinario {
	public static void recorrerAmplitud(Nodo raiz){
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
	public static void main(String[] args) {
		
		Nodo raiz=new Nodo("MisArchivos");
		Nodo carA=new Nodo("CarpetaA");
		Nodo carB=new Nodo("CarpetaB");
		Nodo carC=new Nodo("CarpetaC");
		Nodo carD=new Nodo("CarpetaD");
		Nodo carE=new Nodo("CarpetaE");
		Nodo Atxt=new Nodo("A.txt");
		Nodo Btxt=new Nodo("B.txt");
		Nodo BBtxt=new Nodo("BB.txt");
		Nodo Dtxt=new Nodo("D.txt");
		Nodo DDtxt=new Nodo("DD.txt");
		Nodo Etxt=new Nodo("E.txt");
		Nodo EEtxt=new Nodo("EEtxt");
		
		raiz.setIzq(carA);
		raiz.setDer(carC);
		carA.setIzq(Atxt);
		carA.setDer(carB);
		carB.setIzq(Btxt);
		carB.setDer(BBtxt);
		carC.setIzq(carD);
		carC.setDer(carE);
		carD.setIzq(Dtxt);
		carD.setDer(DDtxt);
		recorrerAmplitud(raiz);
	}

}
