package aplicacion.otro;

import java.util.LinkedList;
import java.util.List;

public class Nodo {
 private boolean visitado;
 private String Nombre;
 private List <Nodo> vecinos;

    public Nodo(String Nombre) {
        this.visitado =false;
        this.Nombre = Nombre;
        this.vecinos = new LinkedList<Nodo>();
    }
    public void agregarVecinos(Nodo nuevo){
    this.vecinos.add(nuevo);
    
    }

    @Override
    public String toString() {
        return Nombre + " ";
    }
    public boolean isVisitado() {
        return visitado;
    }

    public void setVisitado(boolean visitado) {
        this.visitado = visitado;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public List<Nodo> getVecinos() {
        return vecinos;
    }

    public void setVecinos(List<Nodo> vecinos) {
        this.vecinos = vecinos;
    }
    
}
