using System;

namespace VigesimoPrimeiroDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira a quantidade de movimentos desejados: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a posição da moeda (A/B/C): ");
            string posicao = Console.ReadLine().ToUpper();
            Console.WriteLine("Insira os movimentos abaixo: ");
            for (int i = 0; i < n; i++) {
                int movimento = int.Parse(Console.ReadLine());
                if (posicao == "A" && movimento == 1)
                    posicao = "B";
                else if (posicao == "B" && movimento == 1)
                    posicao = "B";
                else if (posicao == "C" && movimento == 1)
                    posicao = "C";
                else if (posicao == "A" && movimento == 2)
                    posicao = "A";
                else if (posicao == "B" && movimento == 2)
                    posicao = "C";
                else if (posicao == "C" && movimento == 2)
                    posicao = "C";
                else if (posicao == "A" && movimento == 3)
                    posicao = "A";
                else if (posicao == "B" && movimento == 3)
                    posicao = "B";
                else if (posicao == "C" && movimento == 3)
                    posicao = "A";
            }
            Console.WriteLine("A moeda está na posição: " + posicao.ToUpper());
        }
    }
}
