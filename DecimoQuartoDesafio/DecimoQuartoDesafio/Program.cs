using System;

namespace DecimoQuartoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com dois valores na mesma linha: ");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            SistemaCartesiano quadrante = new SistemaCartesiano(x, y);
            Console.WriteLine(quadrante);
        }
    }
}
