using System;

namespace Programa17_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas de las matrices: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número de columnas de las matrices: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            int[,] matrizA = new int[filas, columnas];
            int[,] matrizB = new int[filas, columnas];
            int[,] resultado = new int[filas, columnas];

            Console.WriteLine("Ingrese los valores para la matriz A:");
            Sol_Valores(matrizA);

            Console.WriteLine("Ingrese los valores para la matriz B:");
            Sol_Valores(matrizB);

            Mult_Matrices(matrizA, matrizB, resultado);

            Console.WriteLine("La matriz resultante es:");
            Mostrar_Matriz(resultado);
        }

        private static void Sol_Valores(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Ingrese el valor en la posición [{i}][{j}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        private static void Mult_Matrices(int[,] matrizA, int[,] matrizB, int[,] resultado)
        {
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrizA.GetLength(1); k++)
                    {
                        resultado[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }
        }

        private static void Mostrar_Matriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
