using System;

namespace Proyecto5u3
{
    internal class Proyecto5u3
    {

        static void main(String[] args)
        {

            double p1, p2, p3, total;

            Console.Write("Escribe el precio 1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escribe el precio 2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escribe el precio 3: ");
            p3 = Convert.ToDouble(Console.ReadLine());
            total = p1 + p2 + p3;
            if (total >= 1500)
            {
                total = total - (total * 0.30);
                Console.WriteLine("El total (30%desc): " + total);
            }
            else if (total < 1500 && total >= 1000)
            {
                total = total - (total * 0.20);
                Console.WriteLine("El total (20%desc): " + total);
            }
            else if (total < 1000 && total >= 700)
            {
                total = total - (total * 0.10);
                Console.WriteLine("El total (10%desc): " + total);
            }
            else
            {
                Console.WriteLine("El total (sin desc): " + total);
            }
        }
    }
