/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa16_u4;

/**
 *
 * @author LaboratorioLTI2
 */

public class Programa16_U4 {
    public static void main(String[] args) {
        int filas = 2;
        int columnas = 3;

        char[][] matriz = {
                {'f', 'b', 'c'},
                {'d', 'a', 'e'}
        };

        System.out.println("Matriz original:");
        M_Matriz(matriz);

        System.out.println("\nDatos al revés:");
        Imp_AlReves(matriz);
    }
    
    static void M_Matriz(char[][] matriz) {
        int filas = matriz.length;
        int columnas = matriz[0].length;

        for (int i = 0; i < filas; i++) {
            for (int j = 0; j < columnas; j++) {
                System.out.print(matriz[i][j] + "\t");
            }
            System.out.println();
        }
    }

    static void Imp_AlReves(char[][] matriz) {
        int filas = matriz.length;
        int columnas = matriz[0].length;

        for (int i = filas - 1; i >= 0; i--) {
            for (int j = columnas - 1; j >= 0; j--) {
                System.out.print(matriz[i][j] + "\t");
            }
            System.out.println();
        }
    }
}