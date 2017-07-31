package proyectotateti;

public class Celda {

    private boolean Marcado;
    private String dibujoFicha;
    private Ficha ficha;

    public String getDibujoFicha() {
        return dibujoFicha;
    }

    public boolean isMarcado() {
        return Marcado;
    }

    public void setMarcado(boolean marcado, String dibujoFicha) {
        Marcado = marcado;
        this.dibujoFicha = dibujoFicha;
        if (dibujoFicha.equals("X")) {
            this.ficha = Ficha.X;
        } else {
            this.ficha = Ficha.O;
        }
    }

    public boolean isFicha(Jugador jugador) {
      //si es igual la ficha que se encuentra en esta celda,o
      //es diferente con respecto al jugador actual
        return this.ficha==jugador.getFicha();
    }

}
