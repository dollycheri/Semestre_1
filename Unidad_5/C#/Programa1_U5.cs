using System;

namespace Programa1_U5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma = " + Suma(7, 8));
            Console.WriteLine("Resta = " + Resta(13, 3));
            Console.WriteLine("Multiplicación = " + Multiplicacion(7, 6));
            Console.WriteLine("División = " + Division(15, 3));
        }

        public static int Suma(int a, int b)
        {
            int s = a + b;
            return s;
        }

        public static int Resta(int a, int b)
        {
            int r = a - b;
            return r;
        }

        public static int Multiplicacion(int a, int b)
        {
            int m = a * b;
            return m;
        }

        public static int Division(int a, int b)
        {
            int d = a / b;
            return d;
        }
    }
}
