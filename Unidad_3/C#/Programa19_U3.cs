using System;

namespace Programa19_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int igualACero = 0;
            int mayorACero = 0;
            int menorACero = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                {
                    igualACero++;
                }
                else if (numero > 0)
                {
                    mayorACero++;
                }
                else
                {
                    menorACero++;
                }
            }

            Console.WriteLine("Cantidad de números iguales a cero: " + igualACero);
            Console.WriteLine("Cantidad de números mayores que cero: " + mayorACero);
            Console.WriteLine("Cantidad de números menores que cero: " + menorACero);
        }
    }
}