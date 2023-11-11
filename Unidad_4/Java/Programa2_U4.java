/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa2_u4;

/**
 *
 * @author leebc
 */
import java.util.Scanner;

public class Programa2_U4 {
    public static void main(String[] args) {
        // Declarar un arreglo para almacenar las calificaciones
        double[] calificaciones = new double[10];

        // Crear un objeto Scanner para leer la entrada del usuario
        Scanner sc = new Scanner(System.in);

        // Pedir al usuario que ingrese las calificaciones
        for (int i = 0; i < 10; i++) {
            System.out.print("Ingrese la calificación " + (i + 1) + ": ");
            calificaciones[i] = Double.parseDouble(sc.nextLine());
        }

        // Calcular el promedio
        double suma = 0;
        for (int i = 0; i < 10; i++) {
            suma += calificaciones[i];
        }

        double promedio = suma / 10;

        // Mostrar el promedio
        System.out.println("El promedio de las calificaciones es: " + promedio);

        // Cerrar el objeto Scanner
        sc.close();
    }
}

