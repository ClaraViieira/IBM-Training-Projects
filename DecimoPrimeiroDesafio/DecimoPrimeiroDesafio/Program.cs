using System;
using System.Globalization;

namespace DecimoPrimeiroDesafio {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ImpostoDeRenda imposto = new ImpostoDeRenda(salario);
            Console.WriteLine(imposto);
        }
    }
}
