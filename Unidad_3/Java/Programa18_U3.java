
package com.mycompany.programa18_u3;


public class Programa18_U3 {

   
    public static void main(String[] args) {
        double salarioInicial = 1500; 
        double tasaIncremento = 0.10; 
        int numAños = 6; 
        
        System.out.println("Salario inicial del profesor: $" + salarioInicial);

        for (int i = 1; i <= numAños; i++) {
            salarioInicial = salarioInicial + (salarioInicial * tasaIncremento);
            System.out.println("Salario en el año " + i + ": $" + salarioInicial);
        }

        System.out.println("Salario después de " + numAños + " años: $" + salarioInicial);
    }
}
