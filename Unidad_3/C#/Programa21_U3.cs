using System;

namespace Programa21_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            int contador = 1;

            while (contador <= cantidadNumeros)
            {
                Console.Write("Ingrese un número natural positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    int cubo = numero * numero * numero;
                    Console.WriteLine("El cubo de " + numero + " es " + cubo);
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número natural positivo.");
                }

                contador++;
            }
        }
    }
}