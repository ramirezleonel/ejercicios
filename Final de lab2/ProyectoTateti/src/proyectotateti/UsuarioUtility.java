package proyectotateti;

import java.util.InputMismatchException;
import java.util.Random;
import java.util.Scanner;

public final class UsuarioUtility {

    private UsuarioUtility() {

    }

    public static void ingreseEnter() {
        Scanner tec = new Scanner(System.in);
        System.out.println("ingrese enter para Salir...");
        tec.nextLine();
    }

    public static int ingresePosicion() {
        boolean bandera = false;
        Scanner tec;
        int pos = 0;
        do {
            try {
                tec = new Scanner(System.in);
                System.out.println("ingrese una posicion del tablero");
                pos = tec.nextInt();
                if (pos <= 2 && pos >= 0) {
                    bandera = true;
                    return pos;
                } else {
                    throw new ValorIncorrectoException("Fuera de los limites");
                }

            } catch (ValorIncorrectoException e) {
                e.getMessage();
            } catch (Exception e) {
                System.out.println("Ingresaste un String");

            }
        } while (bandera == false);

        return pos;
    }

    public static void presentacionJuego() {
        System.out.println(" \t ##JUEGO TATETI 3D##");
        System.out.println("****************************************");
        System.out.println("Instrucciones del juego");
        System.out.println("para colocar la ficha (X o O) previamente seleccionada \n"
                + "debe ingresar valores numericos enteros para conocer sus \n"
                + "posicion en el tablero correspondiente a su FILA COLUMNA \n"
                + "en ese orden respectivamente");
        System.out.println("\nIMPORTANTE:EL JUEGO ACABA CUANDO TODO EL TABLERO ESTE LLENO \n");

    }

    public static void reglasJuego() {
        System.out.println("Reglas del juego");
        System.out.println("****************************************");
        System.out.println("No está permitido ingresar valores no numericos,"
                + "\n tampoco valores que no correspondan a los valores dentro del rango aceptable"
                + "Rango Aceptable [0,2]");
        System.out.println("EL Jugador ganador es el que tiene mayor puntos");

        System.out.println("Empezemos...");
    }

    public static Ficha elegirFicha() {
        boolean bandera = false;
        Scanner teclado;
        while (bandera == false) {
            teclado = new Scanner(System.in);
            try {
                int opcion;
                System.out.println("Elija una ficha ");
                System.out.println("presione 1 si desea:  \"X\" ");
                System.out.println("presione 2 si desea:  \"O\" ");

                opcion = teclado.nextShort();
                switch (opcion) {
                    case 1:
                        System.out.println("La ficha elegida es \"X\"");

                        return Ficha.X;

                    case 2:
                        System.out.println("La ficha elegida es \"O\"");
                        return Ficha.O;

                    default:
                        throw new ValorIncorrectoException();
                }

            } catch (ValorIncorrectoException error) {
                error.getMessage();

            } catch (InputMismatchException entrada) {
                System.out.println("Error: No ingresaste valores Numerico");

            }

        }
        return Ficha.O;
    }

    public static void elegirTurnoInicial(Jugador jugador1, Jugador jugador2) {
        Random aleatorio = new Random();
        //aleatorio.ints(1, 2);
        //elige un aleatorio entre 1 y 2
        //1 representa el jugador1 y 2 jugador2 

        int random = 1 + aleatorio.nextInt(2);
        if (random == 1) {

            jugador1.setTurno(true);
            jugador2.setTurno(false);
            System.out.println("Comienza jugando el jugador1 -->" + jugador1.getNombre() + "\n");
        } else if (random == 2) {

            jugador2.setTurno(true);
            jugador1.setTurno(false);
            System.out.println("Comienza jugando jugador2-->" + jugador2.getNombre() + "\n");
        }
        Scanner tec = new Scanner(System.in);
        System.out.println("PRESIONE ENTER PARA CONTINUAR...");
        if (tec.hasNextLine()) {

        }
    }

    public static String elegirNombreJugador() {
        Scanner tec;
        tec = new Scanner(System.in);
        System.out.println("Ingrese Un nombre para su jugador...");
        return tec.next();
    }

    public static int elegirFiguraTablero() {
        boolean bandera = false;
        Scanner tec;
        int figura = 0;
        do {
            try {
                tec = new Scanner(System.in);
                System.out.println("Ingrese Una figura del tablero...");
                figura = tec.nextInt();
                if (figura <= 3 && figura > 0) {
                    bandera = true;
                } else {
                    throw new ValorIncorrectoException();
                }
            } catch (ValorIncorrectoException valorIncorrecto) {
                valorIncorrecto.getMessage();

            } catch (Exception v) {
                System.out.println("valor ingresado incorrecto es un String ");

            }
        } while (bandera == false);

        return figura;
    }
}
