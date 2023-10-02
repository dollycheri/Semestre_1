using System;

namespace P_8 // Note: actual namespace depends on the project name.
{
    internal class IVA
    {
        static void Main(string[] args)
        {
            int p1, p2, p3, subt, t, iva;
            Console.WriteLine("¿Qué precio tiene el 1er producto?");
            p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Qué precio tiene el 2do producto?");
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Qué precio tiene el 3er producto?");
            p3 = Convert.ToInt32(Console.ReadLine());

            subt = (int)((int)(p1 / 1.16) + (p2 / 1.16) + (p3 / 1.16));
            Console.WriteLine("El subtotal es :" + subt);

            t = p1 + p2 + p3;
            Console.WriteLine("El total es :" + t);

            iva = t - subt;
            Console.WriteLine("El IVA es :" + iva);
        }
    }
}
