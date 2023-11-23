using System;

namespace Programa18_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] diag = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Diagonal principal: ");
            for (int c = 0; c < diag.GetLength(0); c++)
            {
                Console.WriteLine(diag[c, c] + " ");
            }

            Console.WriteLine("Diagonal inversa:  ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(diag[i, diag.GetLength(1) - 1 - i]);
            }

            Console.WriteLine("Diagonal secundaria:  ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(diag[i, i + 1] + " ");
            }
        }
    }
}