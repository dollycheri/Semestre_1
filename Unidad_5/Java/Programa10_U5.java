/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa10_u5;
import java.util.Random;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa10_U5 {

    public static void main(String[] args) {
        int num;
        num = aleatorio(); 
        System.out.println(num);
    }
    public static int aleatorio(){
        
        Random random = new Random();
    return random.nextInt();
    
    }
    
}
