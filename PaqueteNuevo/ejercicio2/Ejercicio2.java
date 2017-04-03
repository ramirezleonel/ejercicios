package ejercicio2;

public class Ejercicio2 {
	public static int[]valores={1,2,3,4,5,6,7,8,9,10};
	
	public static int buscar(int[] valores, int inicio, int fin, int a) {
		int posicion;
		posicion = inicio + fin / 2;
		if (inicio > fin){
			return -1;
		}
		else if (posicion == a) {
			return posicion;
		} else if (valores[posicion] > a){
			return buscar(valores, inicio, posicion - 1, a);
		}
		else{
			return buscar(valores, posicion + 1, fin, a);
		}
	}

	public static void main(String[] args) {
		System.out.println(buscar(valores, 0, 9, 3));
		
	}
}
