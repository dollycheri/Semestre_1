/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa_9;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa_9 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int N1,N2,s,r,d,m;
        System.out.print("Escribe un número:");
        N1 = sc.nextInt ();
        System.out.print("Escribe un número:");
        N2 = sc.nextInt ();
        
        s = N1 + N2;
        System.out.println("El resultado de la suma es: " + s);
        
        r = N1 - N2;
        System.out.println("El resultado de la resta es: " + r);
        
        m = N1 * N2;
        System.out.println("El resultado de la multiplicación es: " + m);
        
        d = N1 / N2;
        System.out.println("El resultado de la división es: " + d);
    }
}
