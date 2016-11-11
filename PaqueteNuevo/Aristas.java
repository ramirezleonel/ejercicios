package PaqueteNuevo;

public class Aristas {
    private int costo;
    private Nodo primero;
    private Nodo ultimo;

    public Aristas(int costo, Nodo primero, Nodo segundo) {
        this.costo = costo;
        this.primero = primero;
        this.ultimo = segundo;
        primero.listaAristas.add(this);
        segundo.listaAristas.add(this);
    }

    @Override
    public String toString() {
        return  costo + "";
    }

  
    
    public int getCosto() {
        return costo;
    }

    public void setCosto(int costo) {
        this.costo = costo;
    }

    public Nodo getPrimero() {
        return primero;
    }

    public void setPrimero(Nodo primero) {
        this.primero = primero;
    }

    public Nodo getUltimo() {
        return ultimo;
    }

    public void setUltimo(Nodo ultimo) {
        this.ultimo = ultimo;
    }
    
}
