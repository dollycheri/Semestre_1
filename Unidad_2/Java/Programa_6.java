/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa_6;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa_6 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int c,f;
        System.out.print("Introduce el valor de los grados: ");
        c = sc.nextInt ();
        f = (c * 9/5) + 32;
        System.out.print("Los grados fahrenheit son: " + f);
    }
}
