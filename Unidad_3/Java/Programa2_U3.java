/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.p2_u3;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class P2_U3 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int C1,C2,C3,C4,C5,C6,prom;
        System.out.println("¿Cuál es la 1ra calificación? ");
        C1 =sc.nextInt();
        System.out.println("¿Cuál es la 2da calificación? ");
        C2 =sc.nextInt();
        System.out.println("¿Cuál es la 3ra calificacoión");
        C3 =sc.nextInt();
        System.out.println("¿Cuál es la 4ta calificación? ");
        C4 =sc.nextInt();
        System.out.println("¿Cuál es la 5ta calificación? ");
        C5 =sc.nextInt();
        System.out.println("¿Cuál es la 6ta calificación? ");
        C6 =sc.nextInt();
        
        prom=(C1+C2+C3+C4+C5+C6)/6;
        
        if (prom>=70){
        System.out.println("Aprobado"); 
        }
        else{
        System.out.println("Reprobado");
        }
    }
}
