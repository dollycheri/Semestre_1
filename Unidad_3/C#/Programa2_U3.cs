using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int C1, C2, C3, C4, C5, C6, prom;
            Console.WriteLine("¿Cuál es la 1ra calificación? ");
            C1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuál es la 2da calificación? ");
            C2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuál es la 3ra calificacoión");
            C3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuál es la 4ta calificación? ");
            C4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuál es la 5ta calificación? ");
            C5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuál es la 6ta calificación? ");
            C6 = Convert.ToInt32(Console.ReadLine());

            prom = (C1 + C2 + C3 + C4 + C5 + C6) / 6;

            if (prom >= 70)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
    }
}