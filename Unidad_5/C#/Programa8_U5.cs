using System;

class Programa8_U5
{
    static void Main()
    {
        int numero_Dados = 2; 
        int resultado = Lanzar_Dados(numero_Dados);

        Console.WriteLine("Resultado del lanzamiento: " + resultado);
    }

    static int Lanzar_Dados(int numero_Dados)
    {
        Random random = new Random();
        int resultado = 0;

        for (int i = 0; i < numero_Dados; i++)
        {
            int valor_Dado = random.Next(1, 7);
            Console.WriteLine($"Dado {i + 1}: {valor_Dado}");

            resultado += valor_Dado;
        }

        return resultado;
    }
}
