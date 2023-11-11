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

        double[] calificaciones = new double[10];
        
        Scanner sc = new Scanner(System.in);

     
        for (int i = 0; i < 10; i++) {
            System.out.print("Ingrese la calificación " + (i + 1) + ": ");
            calificaciones[i] = Double.parseDouble(sc.nextLine());
        }

   
        double suma = 0;
        for (int i = 0; i < 10; i++) {
            suma += calificaciones[i];
        }

        double promedio = suma / 10;

        System.out.println("El promedio de las calificaciones es: " + promedio);

        sc.close();
    }
}

