using System;

namespace MyCompany.BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[] { 17, 19, 18, 18, 18, };
            int[] edades2 = new int [] { 17, 19, 18, 18, 18 };

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("indice: " + i + "es: " + edades[i]);
                if (edades[i] >= 18)
                    Console.WriteLine("Eres Mayor");
                else
                    Console.WriteLine("Eres Menor");
            }

        }
    }
}