package proyectotateti;

public class Figura {

    private Celda[][] celdas;
    //dimensiones no va a variar en ningun momento
    private static final int dimensiones = 3;

    public Figura() {

        celdas = new Celda[dimensiones][dimensiones];
        //inicializo las celdas de la figura
        for (int i = 0; i < celdas.length; i++) {
            //filas
            for (int j = 0; j < celdas.length; j++) {
                //columnas
                celdas[i][j] = new Celda();
                celdas[i][j].setMarcado(false, " ");
            }

        }

    }

    public void dibujarFigura() {
        System.out.println();
        for (int i = 0; i < celdas.length; i++) {
            for (int j = 0; j < celdas.length; j++) {

                if (j != 0 && j != 2) {
                    System.out.print("|  " + celdas[i][j].getDibujoFicha() + "  |");

                } else {
                    System.out.print(" " + celdas[i][j].getDibujoFicha() + " ");
                }

            }
            System.out.println();
            if (i != 2) {
                System.out.println("_____________");
            }

        }
        System.out.println();

    }

    //actualiza la figura en la posicionfila y posicioncolum del arreglo de celdas
    public void actualizarFigura(Jugador jugador) {
        int posFila, posColum;
        boolean noDibuje = true;

        while (noDibuje) {
            posFila = UsuarioUtility.ingresePosicion();
            posColum = UsuarioUtility.ingresePosicion();
            //si no esta marcado lo marco y salgo del while
            if (!celdas[posFila][posColum].isMarcado()) {
                celdas[posFila][posColum].setMarcado(true, jugador.dibujar());
                noDibuje = false;
            } else {
                System.out.println("La posicion [" + posFila + "],[" + posColum + "] ya está marcado");
                System.out.println("Intente Nuevamente...");
            }

        }

    }

    public boolean isLleno() {
        for (int i = 0; i < celdas.length; i++) {
            for (int j = 0; j < celdas.length; j++) {
                if (celdas[i][j].isMarcado() == false) {
                    //si existe una celda que este en falso no esta lleno
                    return false;
                }

            }
        }
        return true;
    }

    public Celda[][] getCeldas() {
        return celdas;
    }

    public void setCeldas(Celda[][] celdas) {
        this.celdas = celdas;
    }
}
