using System;
using System.Globalization;

namespace NonoDesafio {
    class Program {
        static void Main(string[] args) {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CalculoSalario calculo = new CalculoSalario(salario);
            Console.WriteLine("Novo salário: " + calculo.NovoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + calculo.ValorReajustado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + calculo.Percentual + "%");
        }
    }
}
