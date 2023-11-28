using System;

class Program
{
    static void Main()
    {
        int n = 5;

        int numero_entero = 42;

        int[,] matriz = new int[n, n];

        llenar_matriz(matriz, numero_entero);

        mostrar_matriz(matriz);
    }

    static void llenar_matriz(int[,] matriz, int numero_entero)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                if (i == c)
              {
                   matriz[i, c] = 1;
                }
               else if (i + c == matriz.GetLength(0) - 1)
               {
                  matriz[i, c] = 0;
                }
                else
              {
                   matriz[i, c] = numero_entero;
                }
            }
        }
    }

    static void mostrar_matriz(int[,] matriz)
    {
       for (int i = 0; i < matriz.GetLength(0); i++)
        {
          for (int c = 0; c < matriz.GetLength(1); c++)
            {
              Console.Write(matriz[i, c] + "\t");
            }
            Console.WriteLine();
        }
    }
}