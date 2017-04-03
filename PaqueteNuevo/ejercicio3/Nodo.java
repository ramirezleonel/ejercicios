package ejercicio3;


	
	public class Nodo {
		private Nodo siguiente;   
		private int dato;

		    @Override
		    public String toString() {
		        return  dato + " ";
		    }

		    public Nodo() {
		        this.siguiente =null;
		       
		    }
		    public Nodo getSiguiente() {
		        return siguiente;
		    }

		    public void setSiguiente(Nodo siguiente) {
		        this.siguiente = siguiente;
		    }

		    public int getDato() {
		        return dato;
		    }

		    public void setDato(int dato) {
		        this.dato = dato;
		    }


		}

	
		

