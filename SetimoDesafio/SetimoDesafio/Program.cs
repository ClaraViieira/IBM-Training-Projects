using System;
using System.Globalization;

namespace SetimoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double somaTotal = CalculoLanche.ValorTotal(codigo, quantidade);
            Console.WriteLine("Total: R$ " + somaTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
