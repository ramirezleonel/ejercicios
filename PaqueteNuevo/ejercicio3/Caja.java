package ejercicio3;

public class Caja {
	private Cola cola1;
	private Cola cola2;

	private int perSeFueron = 0;
	private int clientesEnLacola = 0;

	public int getClientesEnLacola() {
		clientesEnLacola = cola1.getTamaño() + cola2.getTamaño();
		return clientesEnLacola;
	}

	@Override
	public String toString() {
		return "Cajas" + "clientesAtendidos=" + "cola1: "
				+ cola1.getClientesAtendidos() + "cola2: "
				+ cola2.getClientesAtendidos();
	}


	public int getPerSeFueron() {
		return perSeFueron;
	}

	public Caja() {
		cola1 = new Cola();
		cola2 = new Cola();

	}

	public Cola getCola1() {
		return cola1;
	}

	public void setCola1(Cola cola1) {
		this.cola1 = cola1;
	}

	public Cola getCola2() {
		return cola2;
	}

	public void setCola2(Cola cola2) {
		this.cola2 = cola2;
	}

	public void elegirCaja() {
		if (cola1.sonMasDe10() && cola2.sonMasDe10()) {
			perSeFueron++;

		}else{
			if(cola1.getTamaño()<=cola2.getTamaño()){
				
				cola1.encolar();
				
			}if(cola2.getTamaño()<cola1.getTamaño()){
				cola2.encolar();
				
			}
			
			
		}
		
	}
}
