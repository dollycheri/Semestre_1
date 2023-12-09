using System;

namespace Programa10_U5
{
    class Programa10_U5
    {
        static void Main(string[] args)
        {
            int longitud = 8;
            string contrasena = GenerarContrasena(longitud);
            Console.WriteLine("Contraseña: " + contrasena);
        }

        static string GenerarContrasena(int longitud)
        {
            string caracteres = "ABCDEFghijkl0123456789*-_.";
            Random random = new Random();
            char[] cadena = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                int indiceCaracter = random.Next(caracteres.Length);
                cadena[i] = caracteres[indiceCaracter];
            }

            return new string(cadena);
        }
    }
}
