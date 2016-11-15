package javaapplication2;

public class Cola {

    private Nodo primero;
    private Nodo ultimo;
    private int tamaño;
    private int minCajera;
    private int clientesAtendidos = 0;

    public int getClientesAtendidos() {
        return clientesAtendidos;
    }

    public int getMinCajera() {
        return minCajera;
    }

    public void setMinCajera(int minCajera) {
        this.minCajera = minCajera;
    }

    public Cola() {
        this.primero = null;
        this.ultimo = null;
        this.tamaño = 0;
    }

    public boolean sonMasDeSeis() {
        return this.tamaño == 6;

    }

    public boolean isVacio() {
        if (this.primero == null) {
            return true;
        } else {
            return false;
        }
    }

    public void desencolar() {

        if (isVacio()) {
            System.out.println("esta vacio");
        } else {

            this.primero = this.primero.getSiguiente();
            this.tamaño--;
            clientesAtendidos++;
        }

    }

    public void imprimir() {
        if (isVacio()) {
            System.out.println("Cola vacia");
        } else {
            Nodo aux = this.primero;
            for (int i = 0; i < this.tamaño; i++) {
                System.out.println(aux);
                aux = aux.getSiguiente();
            }
        }
    }

    public void encolar() {
        Nodo nuevo = new Nodo();
        if (isVacio()) {
            this.primero = nuevo;
            this.ultimo = nuevo;
            tamaño++;
        } else if (!sonMasDeSeis()) {
            this.ultimo.setSiguiente(nuevo);
            this.ultimo = nuevo;
            tamaño++;
        }

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

    public int getTamaño() {
        return tamaño;
    }

    public void setTamaño(int tamaño) {
        this.tamaño = tamaño;
    }
}
