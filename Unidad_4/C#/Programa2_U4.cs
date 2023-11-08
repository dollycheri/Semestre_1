using System;

class Program
{
    static void Main()
    {
        // Declarar un arreglo para almacenar las calificaciones
        double[] calificaciones = new double[10];

        // Pedir al usuario que ingrese las calificaciones
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese la calificación {i + 1}: ");
            calificaciones[i] = double.Parse(Console.ReadLine());
        }

        // Calcular el promedio
        double suma = 0;
        for (int i = 0; i < 10; i++)
        {
            suma += calificaciones[i];
        }

        double promedio = suma / 10;

        // Mostrar el promedio
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}