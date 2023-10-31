using System;

namespace Programa16_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            int horas, pago, sueldo;
            while (c <= 20)
            {
                Console.WriteLine("Captura las horas trabajadas");
                horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Captura el pago x hora: ");
                pago = int.Parse(Console.ReadLine());
                sueldo = horas * pago;
                Console.WriteLine("Tu sueldo es: " + sueldo);
                c++;
            }
        }
    }
}