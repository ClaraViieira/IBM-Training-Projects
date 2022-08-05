using System;
using System.Globalization;

namespace QuartoDesafio
{
    class Program
    { 
        static void Main(string[] args)
        {
            int func, horasTrabalhadas;
            double valorHora, salario;
            func = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = horasTrabalhadas * valorHora;
            Console.WriteLine("NUMBER = " + func);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}