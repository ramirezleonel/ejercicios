package proyectotateti;

public class Player extends Jugador {

    public Player(Ficha ficha, String nombre) {
        this.ficha = ficha;
        this.puntos = 0;
        this.nombre = nombre;

    }

    public Player(Jugador jugador, String nombre) {
        //si el jugador2 tiene un tipo de ficha por consiguiente este jugador 
        //tendra la otra
        if (jugador.ficha == Ficha.X) {
            this.ficha = Ficha.O;
        } else {
            this.ficha = Ficha.X;
        }
        this.puntos = 0;
        this.nombre = nombre;

    }

    @Override
    public int getPuntos() {
        return puntos;
    }

    @Override
    public void setPuntos(int puntos) {
        this.puntos = puntos;
    }

    @Override
    public String getNombre() {
        return nombre;
    }

    @Override
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public String dibujar() {

        if (Ficha.X == ficha) {
            return "X";

        } else {
            return "O";
        }
    }

   
}
