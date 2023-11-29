/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa1__u5;

/**
 *
 * @author leebc
 */
public class Programa1__U5 {
    
  public static void main (String[]args)
  {
    System.out.println ("Suma = " + suma (7, 8));
    System.out.println ("Resta = " + resta (13, 3));
    System.out.println ("Multiplicacion = " + multi (7, 6));
    System.out.println ("Division = " + div (15, 3));
  }
  public static int suma (int a, int b)
  {
    int s = a + b;
    return s;
  }
  public static int resta (int a, int b)
  {
    int r = a - b;
    return r;
  }
  public static int multi (int a, int b)
  {
    int m = a * b;
    return m;
  }
  public static int div (int a, int b)
  {
    int d = a / b;
    return d;
  }
}