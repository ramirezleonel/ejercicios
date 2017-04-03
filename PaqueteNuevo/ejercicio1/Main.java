package ejercicio1;

import java.awt.List;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		int actividades=0;
		int inicio=0;
		int fin=0;
		ArrayList <Actividades>lista=new ArrayList<Actividades>();
		Scanner tec=new Scanner(System.in);
		System.out.println("ingrese cant de actividad");
		actividades=tec.nextInt();
		  
		  for (int i = 0; i < actividades; i++) {
			  System.out.println("inicio y final");
			  inicio=tec.nextInt();
			  fin=tec.nextInt();
			  lista.add(new Actividades(inicio,fin));
		}
		  inicio=0;
		  fin=0;
		  for (Actividades activ : lista) {
			if(activ.getInicio()>=fin){
				fin=activ.getFin();
				System.out.println(activ);
				
			}
		}
	}
}
