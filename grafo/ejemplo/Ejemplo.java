/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejemplo;

/**
 *
 * @author LEO
 */
public class Ejemplo {

    public void recorrerProfundidadI(Nodo nodoInicio) {
        if (nodoInicio != null) {
            pila.addNodo(nodoInicio);
            while (pila.size() > 0) {
                Nodo nodoVisitado = pila.getNodo();
                if (nodoVisitado.visitado == false) {
                    nodoVisitado.visitado = true;
                    System.out.print(nodoVisitado.getDato() + ",");
                    llenarPilaNodosAdyacentes(nodoVisitado);
                }
            }
        }
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
    }

}
