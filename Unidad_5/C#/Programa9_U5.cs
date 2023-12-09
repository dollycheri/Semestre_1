using System;

class Programa9_U5
{
    static void Main()
    {
        Console.WriteLine("Ingrese el sueldo diario del trabajador:");
        double sueldo_Diario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tiempo laborado en meses:");
        int meses_Trabajados = Convert.ToInt32(Console.ReadLine());

        double finiquito = Calcular_Finiquito(sueldo_Diario, meses_Trabajados);

        Console.WriteLine($"Finiquito del trabajador: ${finiquito}");
    }

    static double Calcular_SalarioBase(double sueldo_Diario, int meses_Trabajados)
    {
        return sueldo_Diario * 30 * meses_Trabajados;
    }

    static double Calcular_Prestaciones(double sueldo_Diario, int meses_Trabajados)
    {
        return sueldo_Diario * 0.0833 * 30 * meses_Trabajados;
    }

    static double Calcular_Finiquito(double sueldo_Diario, int meses_Trabajados)
    {
        double salario_Base = Calcular_SalarioBase(sueldo_Diario, meses_Trabajados);
        double prestaciones = Calcular_Prestaciones(sueldo_Diario, meses_Trabajados);

        return salario_Base + prestaciones;
    }
}
