package proyectotateti;

public abstract class Jugador {

    protected Ficha ficha;
    private boolean turno;
    protected String nombre;
    protected int puntos;

    public int getPuntos() {
        return puntos;
    }

    public void setPuntos(int puntos) {
        this.puntos = puntos;
    }
    public abstract String dibujar();

    public Ficha getFicha() {
        return ficha;
    }

    public void setFicha(Ficha ficha) {
        this.ficha = ficha;
    }

    public boolean isTurno() {
        return turno;
    }

    public void setTurno(boolean turno) {
        this.turno = turno;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    /*	
	public Jugador(Ficha ficha){
	this.ficha=ficha;

	}*/
}
