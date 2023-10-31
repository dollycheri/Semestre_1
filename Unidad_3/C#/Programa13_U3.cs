using System;

namespace Programa13_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, num;
            for (c = 1; c <= 100; c++)
            {
                Console.WriteLine("Ingresa los valores totales: ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("Es positivo");
                }
                else
                {
                    Console.WriteLine("Es negativo");
                }
            }
        }
    }
}
