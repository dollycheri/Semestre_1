/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa6_u4;

/**
 *
 * @author leebc
 */
public class Programa6_U4 {
    public static void main(String[] args) {
        int[] numeros = { 11, 8, 1, 54, 6, 2 };

        ordenarArreglo(numeros);

        System.out.println("Arreglo Ordenado:");
        imprimirArreglo(numeros);
    }

    static void ordenarArreglo(int[] array) {
        int[] auxiliar = new int[array.length];
        ordenPorInsercion(array, auxiliar);
    }

    static void ordenPorInsercion(int[] array, int[] auxiliar) {
        for (int i = 1; i < array.length; i++) {
            int elementoActual = array[i];
            int j = i - 1;

            while (j >= 0 && auxiliar[j] > elementoActual) {
                auxiliar[j + 1] = auxiliar[j];
                j--;
            }

            auxiliar[j + 1] = elementoActual;
        }

        System.arraycopy(auxiliar, 0, array, 0, array.length);
    }

    static void imprimirArreglo(int[] array) {
        for (int elemento : array) {
            System.out.print(elemento + " ");
        }
        System.out.println();
    }
}
