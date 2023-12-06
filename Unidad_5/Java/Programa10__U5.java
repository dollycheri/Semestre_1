/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa10__u5;
import java.util.Random;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa10__U5 {

    public static void main(String[] args) {
        int longitud = 8;
        String contrasena = aleatorio(longitud); 
        System.out.println("pasword: ,"+contrasena);
    }
    public static String aleatorio(int longitud){
        String caracteres = "ABCDEFghijkl0123456789*-_.";
        Random random = new Random();
        StringBuilder cadena = new StringBuilder(longitud);
        for (int i = 0; i<longitud; i++){
           
            int indiceCaracter = random.nextInt(caracteres.length());
            cadena.append(caracteres.charAt(indiceCaracter));
        }           
    return cadena.toString();
    }
    
}
