//Comentarios en una linea
/*Comentarios en bloque:
 * Console en Writeline para imprimir
 * Para imprimir texto sin variable
 * tiene que ir entre "" comillas dobles*/
using System;

namespace P_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //algoritmo 2
            string nombre = "Frida Michel", apellidos = "Cisneros Paz", completo;
            completo = nombre + apellidos;
            int a = 5; int b = 3, suma;
            suma = a + b;
            Console.WriteLine(suma);
            Console.WriteLine(" * * Bienvenido * * ");
            Console.Write("La operacion suma de a=" + a + " B=" + b);
            Console.Write($" Tu resultados es {suma}");
            Console.WriteLine(" -- Gracias :)");
        }
    }
}