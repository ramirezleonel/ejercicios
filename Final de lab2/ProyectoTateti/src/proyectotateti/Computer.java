package proyectotateti;

public class Computer extends Jugador {

    public Computer(Player jugador1) {
        if (jugador1.getFicha() == Ficha.X) {

            ficha = Ficha.O;
        } else {

            ficha = Ficha.X;
        }

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
