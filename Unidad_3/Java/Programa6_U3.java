
package com.mycompany.programa6;
import java.util.Scanner;

public class programa6 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingrese un número entero: ");
        int numero = scanner.nextInt();

        if (numero % 2 == 0) {
            System.out.println("Es un número par.");
        } else {
            System.out.println("Es un número impar.");
        }
    }
}