using System;
using System.Globalization;

namespace NonoDesafio {
    class Program {
        static void Main(string[] args) {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CalculoSalario calculo = new CalculoSalario(salario);
            Console.WriteLine(calculo);
        }
    }
}
