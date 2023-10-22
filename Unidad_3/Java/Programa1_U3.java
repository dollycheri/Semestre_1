/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.p1_u3;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class P1_U3 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int edad;
        System.out.println("escribe tu edad ");
        edad =sc.nextInt();
        if (edad>=18)
        System.out.println("Eres mayor de edad.");
        else
        System.out.println("Eres menor de edad.");
    }
}
