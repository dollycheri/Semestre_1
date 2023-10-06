package com.mycompany.programa_8;
import java.util.Scanner; 

public class Programa_8 { 

    public static void main(String[] args) { 
        Scanner it = new Scanner (System.in);
        double p1, p2, p3, subtotal, total, ivaT;
        final double iva=0.16;
        System.out.print ( "Escribe el precio 1:");
        p1= it.nextDouble ();
        System.out.print ( "Escribe el precio 2:");
        p2= it.nextDouble ();
        System.out.print ( "Escribe el precio 3:");
        p3= it.nextDouble ();
        total = p1 + p2 + p3;
        ivaT = total * iva;
        subtotal = total - ivaT;
        System.out.println("Total: "+total);
        System.out.println("IVA: "+ivaT);
        System.out.println("Subtotal: "+subtotal);
    }
}
