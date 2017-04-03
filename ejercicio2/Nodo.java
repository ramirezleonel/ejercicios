package parcial1;

import java.util.List;

public class Nodo {
	private String dato;
	private List<Nodo> vecino;
	private boolean Visitado;
	
	public boolean isVisitado() {
		return Visitado;
	}
	public void agregarVecinos(Nodo nuevo){
	    this.vecino.add(nuevo);
	    
	}
	public void setVisitado(boolean visitado) {
		Visitado = visitado;
	}

	public String getDato() {
		return dato;
	}

	public void setDato(String dato) {
		this.dato = dato;
	}

	public Nodo(String dato) {
		this.dato = dato;

	}

	@Override
	public String toString() {
		return dato + " ";
	}

	public List<Nodo> getVecino() {
		return vecino;
	}

	public void setVecino(List<Nodo> vecino) {
		this.vecino = vecino;
	}

}
