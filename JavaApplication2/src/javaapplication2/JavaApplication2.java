package javaapplication2;

public class JavaApplication2 {

    public static void main(String[] args) {
        Cajas cajasSuperMercado = new Cajas();
            for (int i = 1; i < 80; i++) {
            if (i % 7 == 0) {
                cajasSuperMercado.getCola1().desencolar();
            }
            if (i % 9 == 0) {
                cajasSuperMercado.getCola2().desencolar();
            }
            if (i % 11 == 0) {
                cajasSuperMercado.getCola3().desencolar();
            }
            if (i % 2 == 0) {
                cajasSuperMercado.elegirCaja();
            }

        }
        System.out.println("clientes que se fueron" + cajasSuperMercado.getPerSeFueron());
        System.out.println("clientes totales" + cajasSuperMercado.getClientesTotal());
        System.out.println("clientes atendidos" + cajasSuperMercado);
        
        System.out.println("clientes en la cola"+cajasSuperMercado.getClientesEnLacola());
    }

}
