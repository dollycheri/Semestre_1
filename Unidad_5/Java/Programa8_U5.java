/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa8_u5;

/**
 *
 * @author leebc
 */
import java.util.Random;

public class Programa8_U5 {

    public static void main(String[] args) {
      
        int numero_Dados = 2; 
        int resultado = lanzar_Dados(numero_Dados);

        System.out.println("Resultado del lanzamiento: " + resultado);
    }

    public static int lanzar_Dados(int numero_Dados) {
        Random random = new Random();
        int resultado = 0;

        for (int i = 0; i < numero_Dados; i++) {

            int valor_Dado = random.nextInt(6) + 1;
            System.out.println("Dado " + (i + 1) + ": " + valor_Dado);

            resultado += valor_Dado;
        }

        return resultado;
    }
}
