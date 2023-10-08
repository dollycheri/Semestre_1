/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa_4;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa_4 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int y, a, x;
        System.out.print("Dar valor a Y: ");
        y = sc.nextInt ();
        System.out.print("Dar valor a A: ");
        a = sc.nextInt ();
        x = y + a + 3;
        System.out.println("El resultado es " + x);  
        ;
    }
}
