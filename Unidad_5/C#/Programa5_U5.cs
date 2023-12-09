using System;

class Programa5_U5
{
    static void Main()
    {
        Console.WriteLine("Ingrese una frase o palabra:");
        string entrada_Usuario = Console.ReadLine();

        int cantidad_Palabras = Contar_Palabras(entrada_Usuario);

        Console.WriteLine("Número de palabras: " + cantidad_Palabras);
    }

    static int Contar_Palabras(string cadena)
    {
        if (string.IsNullOrEmpty(cadena))
        {
            return 0;
        }

        string[] palabras = cadena.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        return palabras.Length;
    }
}
