namespace Programa17_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            do
            {
                Console.WriteLine("Bienvenido a una sola ejecución");
                Console.WriteLine("¡¡Escribe n para salir!!!");
                opcion = Console.ReadKey().KeyChar;
            } while (opcion != 'n');
        }
    }
}