package aplicacion.otro;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Stack;

public class Recorrido {

    public void recorridoProfundidad(Nodo primero) {
        Stack<Nodo> pila = new Stack<>();
        List<Nodo> visitados = new ArrayList<Nodo>();
        pila.push(primero);
        while (!pila.isEmpty()) {
            Nodo aux = pila.pop();
            if (!visitados.contains(aux)) {
                visitados.add(aux);
                for (Nodo nodos : aux.getVecinos()) {
                    pila.push(nodos);
                }
            }
        }
        for (Nodo visitado : visitados) {
            System.out.println(visitado);
        }

    }

    public void dfs(Nodo start) {
        Stack<Nodo> stack = new Stack<>(); // initialize a stack
        List<Nodo> visited = new ArrayList<>();//maintains order of visited nodes
        stack.push(start); // push the start
        while (!stack.isEmpty()) { //check if stack is empty
            Nodo popped = stack.pop(); // pop the top of the stack
            if (!visited.contains(popped)) { //backtrack if the vertex is already visited
                visited.add(popped); //mark it as visited as it is not yet visited
                for (Nodo adjacent : popped.getVecinos()) { //get the adjacents of the vertex as add them to the stack
                    stack.add(adjacent);
                }
            }
        }

        for (Nodo v1 : visited) {
            System.out.println(v1);
        }
    }

}
