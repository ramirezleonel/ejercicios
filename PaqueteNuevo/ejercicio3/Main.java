package ejercicio3;

public class Main {
	public static void main(String[] args) {
		Caja cajasbanco = new Caja();
		int cantDeTiempoC1=0;
		int cantDeTiempoC2=0;
		for (int i = 1; i < 360; i++) {
			if (i % 8 == 0) {
				cajasbanco.getCola1().desencolar();
				cantDeTiempoC1+=8;
			}
			if (i % 11 == 0) {
				cajasbanco.getCola2().desencolar();
				cantDeTiempoC2+=11;
			}

			if (i % 5 == 0) {
				cajasbanco.elegirCaja();
			}

		}
		System.out.println("clientes que se fueron"
				+ cajasbanco.getPerSeFueron());
		System.out.println("----------------------------------");
		System.out.println("clientes atendidos" + cajasbanco);

		System.out.println("clientes quedaron en la cola"
				+ cajasbanco.getClientesEnLacola());
		System.out.println("tiempo total en la cola 1: "+cantDeTiempoC1);
		System.out.println("tiempo total en la cola 2: "+cantDeTiempoC2);
	}
}
