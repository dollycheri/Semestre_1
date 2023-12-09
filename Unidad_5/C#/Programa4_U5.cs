﻿using System;

class Programa4_U5
{
    static void Main()
    {
        int numero = 24;

        if (EsPrimo(numero))
        {
            Console.WriteLine(numero + " es un número primo.");
        }
        else
        {
            Console.WriteLine(numero + " no es un número primo.");
        }
    }
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false; 
            }
        }
        return true; 
    }
}
