/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa7_u4;

/**
 *
 * @author leebc
 */
import java.util.Arrays;

public class Programa7_U4 {
    public static void main(String[] args) {
        double[] numeros = { 5, 2, 8, 1, 7, 3, 9, 4, 6 };

        double media = C_Media(numeros);
        System.out.println("La media es: " + media);

        double mediana = C_Mediana(numeros);
        System.out.println("La mediana es: " + mediana);
    }

    static double C_Media(double[] array) {
        double suma = 0;

        for (double numero : array) {
            suma += numero;
        }

        return suma / array.length;
    }

    static double C_Mediana(double[] array) {
        Arrays.sort(array);

        int n = array.length;

        if (n % 2 == 0) {
            double elemento1 = array[(n / 2) - 1];
            double elemento2 = array[n / 2];
            return (elemento1 + elemento2) / 2;
        } else {
            return array[n / 2];
        }
    }
}
