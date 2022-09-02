using System;

namespace VigesimoPrimeiroDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira a quantidade de movimentos desejados: ");
            int qteMovimentos = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a posição da moeda (A/B/C): ");
            string moeda = Console.ReadLine().ToUpper();
            Console.WriteLine("Insira os movimentos abaixo: ");
            var jogo = new Jogo(moeda);
            for (int i = 0; i < qteMovimentos; i++) {
                int movimento = int.Parse(Console.ReadLine());
                jogo.TrocaDeMovimento(movimento);
            }
            Console.WriteLine("A moeda está na posição: " + jogo);
        }
    }
}
