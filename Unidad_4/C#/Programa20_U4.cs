using System;

namespace Programa20_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 5, 6 }, { 8, 9 } };
            int[,] res = new int[2, 2];

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 2; c++)
                {
                    res[f, c] = num[f, c] * num[f, c];
                }
            }

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(res[f, c] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}