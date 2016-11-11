package PaqueteNuevo;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Nodo {

    private String name;
    List<Aristas> listaAristas = new LinkedList<Aristas>();
    private boolean encontrado;

    public boolean isEncontrado(String nombre) {
        if (this.getName()==nombre){
            return encontrado;
        } else {
            return false;
        }
    }

    public void setEncontrado(boolean encontrado) {
        this.encontrado = encontrado;
    }

    public Nodo(String name) {
        this.name = name;
    }

    @Override
    public String toString() {
        return name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

}
