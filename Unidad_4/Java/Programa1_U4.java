/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa1_u4;

/**
 *
 * @author leebc
 */
public class Programa1_U4 {

    public static void main(String[] args) {
        int[] edades = { 17, 19, 18, 18, 18 };
        
        for (int i = 0; i < edades.length; i++) {
            System.out.println("indice: " + i + " es: " + edades[i]);
            
            if (edades[i] >= 18)
                System.out.println("Eres Mayor");
            else
                System.out.println("Eres Menor");
        }
    }
}

