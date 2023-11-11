using System;

class Program
{
    static void Main()
    {
        
        string[] frutas = { "Manzana", "Fresa", "Cereza", "Frambuesa", "Granada" };

        
        string[] frutas_AlReves = new string[frutas.Length];

       
        for (int i = 0; i < frutas.Length; i++)
        {
            frutas_AlReves[i] = frutas[frutas.Length - 1 - i];
        }

       
        Console.WriteLine("Arreglo Original:");
        ImprimirArreglo(frutas);

        
        Console.WriteLine("\nArreglo al Revés:");
        ImprimirArreglo(frutas_AlReves);
    }

    static void ImprimirArreglo(string[] array)
    {
        foreach (string elemento in array)
        {
            Console.Write($"{elemento} ");
        }
        Console.WriteLine();
    }
}
