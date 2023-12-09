/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa7_u5;

/**
 *
 * @author leebc
 */
import java.util.Scanner;

public class Programa7_U5 {

    public static void main(String[] args) {
   
        Scanner scanner = new Scanner(System.in);

        System.out.println("Ingrese el subtotal de la factura:");
        double subtotal = scanner.nextDouble();

        double iva = calcular_IVA(subtotal);
        double total = calcular_Total(subtotal, iva);

        System.out.println("Subtotal: $" + subtotal);
        System.out.println("IVA (16%): $" + iva);
        System.out.println("Total: $" + total);
    }
    public static double calcular_IVA(double subtotal) {
        double porcentaje_IVA = 0.16;
        return subtotal * porcentaje_IVA;
    }

    public static double calcular_Total(double subtotal, double iva) {
        return subtotal + iva;
    }
}

