/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa_3;

/**
 *
 * @author LaboratorioLTI2
 */
import java.util.Scanner;
public class Programa_3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int dia;
        System.out.println("Escribe el dia de la semana numerico ");
        dia=sc.nextInt();
        switch(dia){
                case 1:
                System.out.println("Lunes");
                break;
                case 2:
                System.out.println("Martes");
                break;
                case 3:
                System.out.println("Miercoles");
                break;
                case 4:
                System.out.println("Jueves");
                break;
                case 5:
                System.out.println("Viernes");
                break;
                case 6:
                System.out.println("Sabado");
                break;
                case 7:
                System.out.println("Domingo");
                break;
                default:
                    System.out.println("No existe el dia ingresado");
                       }
    }
}
