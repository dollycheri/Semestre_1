using System;

namespace Programa14_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 3;
            int columnas = 3;

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = i + j;
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            int suma = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
            }

            Console.WriteLine("Suma de todos los elementos: " + suma);
        }
    }
}
