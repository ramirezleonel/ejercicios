package ejercicio1;

public class Actividades {
  private int inicio;
  private int fin;
public Actividades(int inicio, int fin) {

	this.inicio = inicio;
	this.fin = fin;
}
@Override
public String toString() {
	return "inicio "+ inicio + " fin " + fin + " ";
}
public int getInicio() {
	return inicio;
}
public void setInicio(int inicio) {
	this.inicio = inicio;
}
public int getFin() {
	return fin;
}
public void setFin(int fin) {
	this.fin = fin;
}
}
