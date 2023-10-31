package com.mycompany.programa21_u3;

import java.util.Scanner;
public class Programa21_U3 {

public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingrese la cantidad de números: ");
        int cantidadNumeros = scanner.nextInt();

        int contador = 1;

        while (contador <= cantidadNumeros) {
            System.out.print("Ingrese un número natural positivo: ");
            int numero = scanner.nextInt();

            if (numero > 0) {
                int cubo = numero * numero * numero;
                System.out.println("El cubo de " + numero + " es " + cubo);
            } else {
                System.out.println("Por favor, ingrese un número natural positivo.");
            }

            contador++;
        }
    }
}