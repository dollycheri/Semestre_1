using System;

class Program
{
    static void Main()
    {
        int filas = 2;
        int columnas = 3;

        char[,] matriz = {
            {'f', 'b', 'c'},
            {'d', 'a', 'e'}
        };

        Console.WriteLine("Matriz original:");
        M_Matriz(matriz);

        Console.WriteLine("\nDatos al revés:");
        Imp_AlReves(matriz);
    }

    static void M_Matriz(char[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Imp_AlReves(char[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = filas - 1; i >= 0; i--)
        {
            for (int j = columnas - 1; j >= 0; j--)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}