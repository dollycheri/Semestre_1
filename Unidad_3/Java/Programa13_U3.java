/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa13_u3;

/**
 *
 * @author LaboratorioLTI2
 */
import java.util.Scanner;
public class Programa13_U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int c, num;
        for(c=1;c<=100;c++)
        {
        System.out.println("Ingresa los valores totales ");
        num=sc.nextInt();
        
        if (num>0)
        {
        
         System.out.println("Es positivo ");
        }else
        {
         System.out.println("Es negativo ");
        }
        }
    }
}