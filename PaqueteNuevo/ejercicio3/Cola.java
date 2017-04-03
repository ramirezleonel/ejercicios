package ejercicio3;

public class Cola {

    private Nodo primero;
    private Nodo ultimo;
    private int tama�o;
    private int clientesAtendidos = 0;
    private int tiempoTotalCola;
    public int getTiempoTotalCola() {
		return tiempoTotalCola;
	}



	public void setTiempoTotalCola(int tiempoTotalCola) {
		this.tiempoTotalCola = tiempoTotalCola;
	}



	public int getClientesAtendidos() {
        return clientesAtendidos;
    }

   

    public Cola() {
        this.primero = null;
        this.ultimo = null;
        this.tama�o = 0;
    }

    public boolean sonMasDe10() {
        return this.tama�o == 10;

    }

    public boolean isVacio() {
        if (this.primero == null) {
            return true;
        } else {
            return false;
        }
    }

    public void desencolar() {

        if (!isVacio()) {

            this.primero = this.primero.getSiguiente();
            this.tama�o--;
            clientesAtendidos++;
        }

    }

    public void imprimir() {
        if (!isVacio()) {
           
       
            Nodo aux = this.primero;
            for (int i = 0; i < this.tama�o; i++) {
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
            tama�o++;
        } else if (!sonMasDe10()) {
            this.ultimo.setSiguiente(nuevo);
            this.ultimo = nuevo;
            tama�o++;
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

    public int getTama�o() {
        return tama�o;
    }

    public void setTama�o(int tama�o) {
        this.tama�o = tama�o;
    }
}