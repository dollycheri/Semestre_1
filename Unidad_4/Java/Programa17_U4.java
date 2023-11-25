/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa17_u4;

import java.util.Scanner;

/**
 *
 * @author leebc
 */
public class Programa17_U4 {

      public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingrese el número de las filas de las matrices: ");
        int filas = scanner.nextInt();

        System.out.print("Ingrese el número de las columnas de las matrices: ");
        int columnas = scanner.nextInt();

        int[][] matrizA = new int[filas][columnas];
        int[][] matrizB = new int[filas][columnas];
        int[][] resultado = new int[filas][columnas];

        System.out.println("Ingrese los valores para la matriz A:");
        sol_Valores(matrizA, scanner);

        System.out.println("Ingrese los valores para la matriz B:");
        sol_Valores(matrizB, scanner);

        mult_Matrices(matrizA, matrizB, resultado);

        System.out.println("La matriz resultante es:");
        mostrar_Matriz(resultado);

        scanner.close();
    }

    private static void sol_Valores(int[][] matriz, Scanner scanner) {
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[0].length; j++) {
                System.out.print("Ingrese el valor en la posición [" + i + "][" + j + "]: ");
                matriz[i][j] = scanner.nextInt();
            }
        }
    }

    private static void mult_Matrices(int[][] matrizA, int[][] matrizB, int[][] resultado) {
        for (int i = 0; i < matrizA.length; i++) {
            for (int j = 0; j < matrizB[0].length; j++) {
                for (int k = 0; k < matrizA[0].length; k++) {
                    resultado[i][j] += matrizA[i][k] * matrizB[k][j];
                }
            }
        }
    }

    private static void mostrar_Matriz(int[][] matriz) {
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz[0].length; j++) {
                System.out.print(matriz[i][j] + " ");
            }
            System.out.println();
        }
    }
}