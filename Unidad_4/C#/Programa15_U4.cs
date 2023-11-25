using System;

namespace Programa15_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            double[,] matriz = new double[filas, columnas];

            Console.WriteLine("Ingrese los elementos de la matriz:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i + 1}][{j + 1}]: ");
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMedia de cada fila:");

            for (int i = 0; i < filas; i++)
            {
                double suma = 0;

                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }

                double media = suma / columnas;
                Console.WriteLine($"Fila {i + 1}: {media}");
            }
        }
    }
}
