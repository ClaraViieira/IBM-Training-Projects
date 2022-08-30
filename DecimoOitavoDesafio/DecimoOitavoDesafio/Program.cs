using System;

namespace DecimoOitavoDesafio {
    class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Insira a quantidade de rodadas: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++) {
                    Console.Write("Primeiro jogador: ");
                    string primeiroJogador = Console.ReadLine();
                    Console.Write("Segundo jogador: ");
                    string segundoJogador = Console.ReadLine();
                    Jogo jogo = new Jogo(primeiroJogador, segundoJogador);
                    Console.WriteLine(jogo);
                }
            }
            catch (FormatException) {
                Console.WriteLine("Erro, digite um número inteiro!");
                    }
        }
    }
}
