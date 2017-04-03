package parcial1;

import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class GrafoParcial {
	
    public void encontrarS(Nodo nodoInicio,Nodo nodofinal) {
    	Queue<Nodo>cola=new LinkedList<Nodo>();
        Stack<Nodo> stack = new Stack<Nodo>();
        stack.push(nodoInicio);
        nodoInicio.setVisitado(true);
        System.out.println(nodoInicio);
        Nodo nodo = stack.peek();
        while (!stack.isEmpty()) {
            
        	if(!nodo.getDato().equals(nodofinal.getDato())){
           
                
            if (nodo.isVisitado() != true) {
                nodo.setVisitado(true);
                System.out.println(nodo);
                
            } else {
                System.out.println(stack.pop());
                stack.addAll(nodo.getVecino());
               
            }
        }else{
        	return;}
        // Clear visited property of nodes
        }
}
    public static void main(String[] args) {
    	Nodo nodo1=new Nodo("I");
        Nodo nodo2=new Nodo(".");
        Nodo nodo3=new Nodo(".");
        Nodo nodo4=new Nodo(".");
        Nodo nodo5=new Nodo(".");
        Nodo nodo6=new Nodo("#");
        Nodo nodo7=new Nodo("S");
        Nodo nodo8=new Nodo(".");
        Nodo nodo9=new Nodo(".");
         nodo1.agregarVecinos(nodo2);
         nodo1.agregarVecinos(nodo3);
         nodo2.agregarVecinos(nodo4);
         nodo2.agregarVecinos(nodo5);
         nodo3.agregarVecinos(nodo6);
         nodo3.agregarVecinos(nodo7);
         nodo3.agregarVecinos(nodo8);
       

	}
}
