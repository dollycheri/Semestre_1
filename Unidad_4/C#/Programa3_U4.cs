using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el total de temperaturas que se van a procesar");
        int totalT = int.Parse(Console.ReadLine());

        double[] tCelsius = new double[totalT];
        double[] tFahrenheit = new double[totalT];
        double[] tKelvin = new double[totalT];

        for (int c = 0; c < totalT; c++)
        {
            Console.Write($"Ingrese la temperatura en °C {c + 1}: ");
            tCelsius[c] = double.Parse(Console.ReadLine());

            tFahrenheit[c] = (tCelsius[c] * 9 / 5) + 32;
            tKelvin[c] = tCelsius[c] + 273.15;
        }

        Console.WriteLine("Resultados:");
        for (int c = 0; c < totalT; c++)
        {
            Console.WriteLine($"Temperatura {c + 1} - {tCelsius[c]:F2}°C = {tFahrenheit[c]:F2}°F = {tKelvin[c]:F2}°K");
        }
    }
}