package aplicacion.otro;

import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class Main {

    public void dfs(Nodo nodoInicio) {
        // DFS uses Stack data structure
        Stack<Nodo> stack = new Stack<Nodo>();
        stack.push(nodoInicio);
        nodoInicio.setVisitado(true);
        System.out.println(nodoInicio);
        Nodo nodo = stack.peek();
        while (!stack.isEmpty()) {
            
            // Nodo noVisitado = nodo.getVecinos(); 
           
           
            if (nodo.isVisitado() != true) {
                nodo.setVisitado(true);
                System.out.println(nodo);
                
            } else {
                System.out.println(stack.pop());
                stack.addAll(nodo.getVecinos());
               
            }
        }
        // Clear visited property of nodes

    }
}
