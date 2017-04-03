package parcial3;

public class Nodo {
	private String dato;
	private Nodo izq;
	private Nodo der;

	public String getDato() {
		return dato;
	}

	public void setDato(String dato) {
		this.dato = dato;
	}

	public Nodo(String dato) {
		this.dato = dato;
		this.izq=null;
		this.der=null;
		
	}

	@Override
	public String toString() {
		return dato +" ";
	}

	public Nodo getIzq() {
		return izq;
	}

	public void setIzq(Nodo izq) {
		this.izq = izq;
	}

	public Nodo getDer() {
		return der;
	}

	public void setDer(Nodo der) {
		this.der = der;
	}
}
