
package com.mycompany.programa19_u3;

 import java.util.Scanner;
public class Programa19_U3 {

  


    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

       
        System.out.print("Ingrese la cantidad de números (N): ");
        int n = scanner.nextInt();

        int igualACero = 0;
        int mayorACero = 0;
        int menorACero = 0;

        for (int i = 0; i < n; i++) {
            System.out.print("Ingrese un número: ");
            int numero = scanner.nextInt();

            if (numero == 0) {
                igualACero++;
            } else if (numero > 0) {
                mayorACero++;
            } else {
                menorACero++;
            }
        }

        System.out.println("Cantidad de números iguales a cero: " + igualACero);
        System.out.println("Cantidad de números mayores que cero: " + mayorACero);
        System.out.println("Cantidad de números menores que cero: " + menorACero);
    }
}