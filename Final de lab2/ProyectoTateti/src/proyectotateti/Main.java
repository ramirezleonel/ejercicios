package proyectotateti;

import java.util.Random;

public class Main {

    public static void main(String[] args) {

        //presentacionJuego 
        UsuarioUtility.presentacionJuego();
        //la ficha y el nombre es seleccionado por el usuario
        //crear los jugadores 
        Player jugador1 = new Player(UsuarioUtility.elegirFicha(), UsuarioUtility.elegirNombreJugador());
        Player jugador2 = new Player(jugador1, UsuarioUtility.elegirNombreJugador());

        //turnos de forma aleatorio
        UsuarioUtility.elegirTurnoInicial(jugador1, jugador2);
        //creo el tablero del juego con las 3 figuras 
        Tablero tablero = new Tablero();
        //mientras no este lleno el tablero completo
        while (!tablero.figura1.isLleno() || !tablero.figura2.isLleno() || !tablero.figura3.isLleno()) {
            //actualiza y luego dibuja el tablero
            if (jugador1.isTurno() == true && jugador2.isTurno() == false) {
                System.out.println("\nEs el turno de "+jugador1.getNombre());
                
                tablero.actualizarTablero( jugador1);
                tablero.dibujarTablero();
                jugador1.setTurno(false);
                jugador2.setTurno(true);
                
            } else {
                  System.out.println("\nEs el turno de "+jugador2.getNombre());
                  
                tablero.actualizarTablero( jugador2);
                tablero.dibujarTablero();
                jugador2.setTurno(false);
                jugador1.setTurno(true);
            }
            jugador1.setPuntos(Puntuacion.actualizarPuntos(tablero, jugador1));
            jugador2.setPuntos(Puntuacion.actualizarPuntos(tablero, jugador2));
            
            System.out.println("Puntos de "+jugador1.getNombre()+":"+jugador1.getPuntos());
            System.out.println("Puntos de "+jugador2.getNombre()+":"+jugador2.getPuntos());
        }
        System.out.println("el juego termino");
        Puntuacion.compararPuntos(jugador1, jugador2);
        UsuarioUtility.ingreseEnter();
    }

}
