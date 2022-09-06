using System;
using System.Globalization;

namespace VigesimoQuartoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira os valores: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int nota, moeda, quociente, resto;
            resto = (int)(valor * 100.0 + 0.5);

            Console.WriteLine("Notas: ");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("Moedas: ");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            moeda = 1;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.01");
            resto = resto % moeda;
        }
    }
}
