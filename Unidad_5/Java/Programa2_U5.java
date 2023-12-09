/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa2_u5;

/**
 *
 * @author leebc
 */
import java.util.Scanner;

public class Programa2_U5 {

    public static void main(String[] args) {
        int opcion;

        Scanner scanner = new Scanner(System.in);

        System.out.println("Elige el tipo de conversión a realizar");
        System.out.println("1. Temperatura C a F ");
        System.out.println("2. Temperatura F a K ");
        System.out.println("3. Medida pulgadas a metros ");
        System.out.println("4. Tiempo horas a segundos ");
        opcion = scanner.nextInt();

        switch (opcion) {
            case 1:
                int c;
                System.out.print("Escriba los grados a convertir: ");
                c = scanner.nextInt();
                System.out.println("Tu resultado es: " + temperaturaCF(c));
                break;
            case 2:
                System.out.println("Tu resultado es: " + temperaturaFK());
                break;
            case 3:
                medida();
                break;
            case 4:
                System.out.println("Tu resultado es: " + tiempo());
                break;
            default:
                System.out.println("La opción es incorrecta");
                break;
        } // FIN SWITCH
    }// FIN MAIN

    public static double temperaturaCF(double c) {
        double resultado = (c * 1.8) + 32;
        return resultado;
    }

    public static double temperaturaFK() {
        double F, resultado;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Escribe la temperatura F a convertir: ");
        F = scanner.nextDouble();
        resultado = (F - 32) * (5 / 9) + 273.15;
        return resultado;
    }

    public static void medida() {
        double p, resultado;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Escribe la medida en pulgadas: ");
        p = scanner.nextDouble();
        resultado = p / 39.37;
        System.out.println("Tu resultado es: " + resultado);
    }

    public static double tiempo() {
        double h, resultado;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Escribe las horas a convertir: ");
        h = scanner.nextDouble();
        return h * 3600;
    }
}
