﻿using System;

namespace P_11 // Note: actual namespace depends on the project name.
{
    internal class Mayor de Edad
    {
        static void Main(string[] args)
        {
            int e;
            Console.WriteLine("¿Qué edad tienes");
            e = Convert.ToInt32(Console.ReadLine());
            if (e >= 18)
            Console.WriteLine("Eres mayor de edad");
            if (e < 18) 
            Console.WriteLine("Eres menor de edad)");

        }
    }
}
