using System;

namespace P_7 // Note: actual namespace depends on the project name.
{
    internal class Metros
    {
        static void Main(string[] args)
        {
            int M, P;
            Console.WriteLine("¿Cuantos metros se desean convertir?");
            M = Convert.ToInt32(Console.ReadLine());
            P = (int)(M * (3.28 / 1));
            Console.WriteLine(M + "metros convertidos a pies es igual a :" + P);
        }
    }
}