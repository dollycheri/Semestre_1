using System;

namespace P_9 // Note: actual namespace depends on the project name.
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            int a, b, s, r, m, d;
            Console.WriteLine("Introduce primer valor");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce segundo valor");
            b = Convert.ToInt32(Console.ReadLine());

            s = a + b;
            Console.WriteLine("La suma es igual a :" + s);
            r = a - b;
            Console.WriteLine("La resta es igual a :" + r);
            m = a * b;
            Console.WriteLine("La multiplicación es igual a :" + m);
            d = a / b;
            Console.WriteLine("La división es igual a :" + d);
        }
    }
}