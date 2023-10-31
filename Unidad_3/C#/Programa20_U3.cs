using System;

namespace Programa20_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            int diasEnUnAño = 365;
            double ahorroDiario = 3.0;
            double ahorroAnual = 0.0;
            int dia = 1;

            while (dia <= diasEnUnAño)
            {
                ahorroAnual += ahorroDiario;
                Console.WriteLine("Día " + dia + ": Ahorro diario = $" + ahorroDiario + ", Ahorro acumulado = $" + ahorroAnual);
                ahorroDiario *= 3;
                dia++;
            }

            Console.WriteLine("Ahorro total en un año: $" + ahorroAnual);
        }
    }
}