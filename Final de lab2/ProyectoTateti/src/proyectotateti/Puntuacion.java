package proyectotateti;

public class Puntuacion {

    public static void compararPuntos(Jugador jugador1, Jugador jugador2) {
        if (jugador1.getPuntos() == jugador2.getPuntos()) {
            System.out.println("hay un empate");
        } else if (jugador1.getPuntos() > jugador2.getPuntos()) {
            System.out.println("ha ganado Jugador: " + jugador1.getNombre());
        } else {
            System.out.println("ha ganado Jugador: " + jugador2.getNombre());
        }

    }

    public static int patron1(Tablero tab, Jugador jug) {
        //PATRON MISMA POSICION EN DISTINTAS FIGURAS
        //FIG1-X;FIG2-X;FIG3-X
        //FIG1-O;FIG2-O;FIG3-O
        int puntos = 0;
        //uso la misma longitud para todas las figuras
        for (int i = 0; i < tab.figura1.getCeldas().length; i++) {
            for (int j = 0; j < tab.figura1.getCeldas().length; j++) {

                //si estan marcado en la misma posicion en las tres figuras
                if (tab.figura1.getCeldas()[i][j].isMarcado() && tab.figura2.getCeldas()[i][j].isMarcado()
                        && tab.figura3.getCeldas()[i][j].isMarcado()) {
                    //compara la ficha
                    if (tab.figura1.getCeldas()[i][j].isFicha(jug)
                            && tab.figura2.getCeldas()[i][j].isFicha(jug)
                            && tab.figura3.getCeldas()[i][j].isFicha(jug)) {
                        puntos++;
                    }
                }
            }
        }
        //return un entero correspondiente a los puntos
        return puntos;
    }

    public static int patron2(Tablero tab, Jugador jug) {
        //PATRON HORIZONTAL X-X-X o O-O-O
        int puntos = 0;
        //uso la misma longitud para todas las figuras
        for (int i = 0; i < tab.figura1.getCeldas().length; i++) {

            if (tab.figura1.getCeldas()[i][0].isMarcado()
                    && tab.figura1.getCeldas()[i][1].isMarcado()
                    && tab.figura1.getCeldas()[i][2].isMarcado()) {

                if (tab.figura1.getCeldas()[i][0].isFicha(jug)
                        && tab.figura1.getCeldas()[i][1].isFicha(jug)
                        && tab.figura1.getCeldas()[i][2].isFicha(jug)) {
                    puntos++;
                }
            }

        }
        for (int i = 0; i < tab.figura2.getCeldas().length; i++) {

            if (tab.figura2.getCeldas()[i][0].isMarcado()
                    && tab.figura2.getCeldas()[i][1].isMarcado()
                    && tab.figura2.getCeldas()[i][2].isMarcado()) {

                if (tab.figura2.getCeldas()[i][0].isFicha(jug)
                        && tab.figura2.getCeldas()[i][1].isFicha(jug)
                        && tab.figura2.getCeldas()[i][2].isFicha(jug)) {
                    puntos++;
                }
            }

        }
        for (int i = 0; i < tab.figura3.getCeldas().length; i++) {

            if (tab.figura3.getCeldas()[i][0].isMarcado()
                    && tab.figura3.getCeldas()[i][1].isMarcado()
                    && tab.figura3.getCeldas()[i][2].isMarcado()) {

                if (tab.figura3.getCeldas()[i][0].isFicha(jug)
                        && tab.figura3.getCeldas()[i][1].isFicha(jug)
                        && tab.figura3.getCeldas()[i][2].isFicha(jug)) {
                    puntos++;
                }
            }

        }
        return puntos;
    }

    public static int patron3(Tablero tab, Jugador jug) {
        //PATRON VERTICAL X o O  
        //                X   O  
        //                X   O 

        int puntos = 0;
        //uso la misma longitud para todas las figuras
        for (int i = 0; i < tab.figura1.getCeldas().length; i++) {

            if (tab.figura1.getCeldas()[0][i].isMarcado()
                    && tab.figura1.getCeldas()[1][i].isMarcado()
                    && tab.figura1.getCeldas()[2][i].isMarcado()) {

                if (tab.figura1.getCeldas()[0][i].isFicha(jug)
                        && tab.figura1.getCeldas()[1][i].isFicha(jug)
                        && tab.figura1.getCeldas()[2][i].isFicha(jug)) {
                    puntos++;
                }
            }

        }
        for (int i = 0; i < tab.figura2.getCeldas().length; i++) {

            if (tab.figura2.getCeldas()[0][i].isMarcado()
                    && tab.figura2.getCeldas()[1][i].isMarcado()
                    && tab.figura2.getCeldas()[2][i].isMarcado()) {

                if (tab.figura2.getCeldas()[0][i].isFicha(jug)
                        && tab.figura2.getCeldas()[1][i].isFicha(jug)
                        && tab.figura2.getCeldas()[2][i].isFicha(jug)) {
                    puntos++;
                }
            }

        }
        for (int i = 0; i < tab.figura3.getCeldas().length; i++) {

            if (tab.figura3.getCeldas()[0][i].isMarcado()
                    && tab.figura3.getCeldas()[1][i].isMarcado()
                    && tab.figura3.getCeldas()[2][i].isMarcado()) {

                if (tab.figura3.getCeldas()[0][i].isFicha(jug)
                        && tab.figura3.getCeldas()[1][i].isFicha(jug)
                        && tab.figura3.getCeldas()[2][i].isFicha(jug)) {
                    puntos++;
                }
            }

        }
        return puntos;
    }

    public static int patron4(Tablero tab, Jugador jug) {
        //PATRON DIAGONAL Hacia Izq X o O
        //                        X   O
        //                      X   O  
        int puntos = 0;
        //uso la misma longitud para todas las figuras
        if (tab.figura1.getCeldas()[0][2].isMarcado()
                && tab.figura1.getCeldas()[1][1].isMarcado()
                && tab.figura1.getCeldas()[2][0].isMarcado()) {
            if (tab.figura1.getCeldas()[0][2].isFicha(jug)
                    && tab.figura1.getCeldas()[1][1].isFicha(jug)
                    && tab.figura1.getCeldas()[2][0].isFicha(jug)) {
                puntos++;
            }

        }
        if (tab.figura2.getCeldas()[0][2].isMarcado()
                && tab.figura2.getCeldas()[1][1].isMarcado()
                && tab.figura2.getCeldas()[2][0].isMarcado()) {
            if (tab.figura2.getCeldas()[0][2].isFicha(jug)
                    && tab.figura2.getCeldas()[1][1].isFicha(jug)
                    && tab.figura2.getCeldas()[2][0].isFicha(jug)) {
                puntos++;
            }
        }
          if (tab.figura3.getCeldas()[0][2].isMarcado()
                && tab.figura3.getCeldas()[1][1].isMarcado()
                && tab.figura3.getCeldas()[2][0].isMarcado()) {
            if (tab.figura3.getCeldas()[0][2].isFicha(jug)
                    && tab.figura3.getCeldas()[1][1].isFicha(jug)
                    && tab.figura3.getCeldas()[2][0].isFicha(jug)) {
                puntos++;
            }
        }
        return puntos;
    }

    public static int patron5(Tablero tab, Jugador jug) {
        //PATRON DIAGONAL Hacia Der X o O
        //                            X   O
        //                              X   O  
        int puntos = 0;
        //uso la misma longitud para todas las figuras
        if (tab.figura1.getCeldas()[0][0].isMarcado()
                && tab.figura1.getCeldas()[1][1].isMarcado()
                && tab.figura1.getCeldas()[2][2].isMarcado()) {
            if (tab.figura1.getCeldas()[0][0].isFicha(jug)
                    && tab.figura1.getCeldas()[1][1].isFicha(jug)
                    && tab.figura1.getCeldas()[2][2].isFicha(jug)) {
                puntos++;
            }

        }
        if (tab.figura2.getCeldas()[0][0].isMarcado()
                && tab.figura2.getCeldas()[1][1].isMarcado()
                && tab.figura2.getCeldas()[2][2].isMarcado()) {
            if (tab.figura2.getCeldas()[0][0].isFicha(jug)
                    && tab.figura2.getCeldas()[1][1].isFicha(jug)
                    && tab.figura2.getCeldas()[2][2].isFicha(jug)) {
                puntos++;
            }

        }
        if (tab.figura3.getCeldas()[0][0].isMarcado()
                && tab.figura3.getCeldas()[1][1].isMarcado()
                && tab.figura3.getCeldas()[2][2].isMarcado()) {
            if (tab.figura3.getCeldas()[0][0].isFicha(jug)
                    && tab.figura3.getCeldas()[1][1].isFicha(jug)
                    && tab.figura3.getCeldas()[2][2].isFicha(jug)) {
                puntos++;
            }

        }
        return puntos;
    }
    
    public static int actualizarPuntos(Tablero tab, Jugador jugador) {
        //actualiza los puntos cada vez que es llamado
        int puntos = 0;
        
        puntos += patron1(tab, jugador);
        puntos += patron2(tab, jugador);
        puntos += patron3(tab, jugador);
        puntos += patron4(tab, jugador);
        puntos += patron5(tab, jugador);
        return puntos;
    }
}
