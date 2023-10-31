using System;

namespace Programa18_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioInicial = 1500;
            double tasaIncremento = 0.10;
            int numAños = 6;

            Console.WriteLine("Salario inicial del profesor: $" + salarioInicial);

            for (int i = 1; i <= numAños; i++)
            {
                salarioInicial = salarioInicial + (salarioInicial * tasaIncremento);
                Console.WriteLine("Salario en el año " + i + ": $" + salarioInicial);
            }

            Console.WriteLine("Salario después de " + numAños + " años: $" + salarioInicial);
        }
    }
}