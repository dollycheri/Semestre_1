/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa4_u4;

/**
 *
 * @author leebc
 */
public class Programa4_U4 {
    public static void main(String[] args) {
        int[] numeros = { 5, -2, 10, -8, 3, -1, 7 };

        int totalN = contarN(numeros);

        System.out.println("El total de números negativos es: " + totalN);
    }

    static int contarN(int[] array) {
        int contador = 0;

        for (int numero : array) {
            if (numero < 0) {
                contador++;
            }
        }

        return contador;
    }
}
