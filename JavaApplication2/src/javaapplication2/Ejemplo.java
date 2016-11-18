import java.util.Scanner;

public class Ejemplo {
	

		public static void main(String[] args) {
			Scanner scan = new Scanner(System.in);
			int n = scan.nextInt(), a[] = new int[n], sum = 0;
			for (int i = 0; i < n; i++) {
				a[i] = scan.nextInt();
				sum += a[i];
			}
			sum = sum / (n / 2);
			for (int i = 0; i < n; i++) {
				for (int j = i + 1; j < n; j++) {
					if (a[i] + a[j] == sum) {
						System.out.println((i + 1) + " " + (j + 1));
						a[i] = -1;
						a[j] = -1;
					}

				}

			}
		}
	}
