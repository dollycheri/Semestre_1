/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa_2;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa_2 {//Paso1

    public static void main(String[] args) {
        Scanner sc= new Scanner (System.in);
        int a, b, suma;//Paso 2 declarar variables
        System.out.print("Escribe un numero A: ");//Paso 3
        a = sc.nextInt();
        System.out.print("Escribe un numero B: ");//Paso 3
        b = sc.nextInt();
        suma=a+b;
        System.out.println("Resultado: "+suma);
    }
}
