package proyectotateti;

public class Tablero {

    Figura figura1, figura2, figura3;

    public Tablero() {
        figura1 = new Figura();
        figura2 = new Figura();
        figura3 = new Figura();
        figura1.dibujarFigura();
        figura2.dibujarFigura();
        figura3.dibujarFigura();
    }

    public void dibujarTablero() {
        //dibuja las tres figuras
        figura1.dibujarFigura();
        figura2.dibujarFigura();
        figura3.dibujarFigura();
    }

    public void actualizarTablero(Jugador jugador) {
        boolean elegir = false;
        int figura;

        while (elegir == false) {
            figura = UsuarioUtility.elegirFiguraTablero();
            switch (figura) {
                case 1:
                    //si no esta lleno elegimos esa opcion
                    if (!figura1.isLleno()) {
                        figura1.actualizarFigura(jugador);
                        elegir = true;
                    } else {
                        System.out.println("Esta lleno");
                    }
                    break;
                case 2:
                     //si no esta lleno elegimos esa opcion
                    if (!figura2.isLleno()) {
                        figura2.actualizarFigura(jugador);
                        elegir = true;
                    } else {
                        System.out.println("Esta lleno");
                    }
                    break;

                case 3:
                     //si no esta lleno elegimos esa opcion
                    if (!figura3.isLleno()) {
                        figura3.actualizarFigura(jugador);
                        elegir = true;
                    } else {
                        System.out.println("Esta lleno");
                    }
                    break;
            }

        }

    }

}
