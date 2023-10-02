using System;

namespace P_10
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lado: ");
            double lado = double.Parse(Console.ReadLine());
            double perimetro = lado * 6;
            Console.WriteLine($"{perimetro} cm");
            Console.ReadKey();
        }
    }
}