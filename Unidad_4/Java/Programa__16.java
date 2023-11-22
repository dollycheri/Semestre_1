/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa__16;
import java.util.Scanner;


/**
 *
 * @author LaboratorioLTI2
 */
public class Programa__16 {

    public static void main(String[] args) {
        Scanner sc= new Scanner ( System.in);
        int c=1, horas, pago, sueldo;
        while (c<=20){
        System.out.println("captura las horas trabajadas");
        horas=sc.nextInt();
        System.out.println("captura el pago por hora");
        pago= sc.nextInt();
        sueldo=horas*pago;
        System.out.println("tu sueldo es: "+sueldo);
        c++;
        
        }
    }
}
