using System;

namespace DecimoQuintoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira dois valores inteiros: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            SomaImpares soma = new SomaImpares(x, y);
            Console.WriteLine(soma);
        }
    }
}
