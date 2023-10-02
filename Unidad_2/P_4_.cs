//Comentarios en una linea
/*Comentarios en bloque:
 * Console en Writeline para imprimir
 * Para imprimir texto sin variable
 * tiene que ir entre "" comillas dobles*/
using System;

namespace P_4
{
    internal class Progrmam
    {
        static void Main(string[] args)
        {

            int y, a;
            int suma = 0;
            float x;
            Console.WriteLine("Escriba el valor de a ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el valor de y ");
            y = Convert.ToInt32(Console.ReadLine());
            suma = y + a + 3;
            Console.WriteLine("Ël valor de x es: " + (suma));

        }
    }
}