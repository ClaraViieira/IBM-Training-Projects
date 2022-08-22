using System;

namespace DecimoSegundoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira os valores necessários abaixo: ");
            string[] vetor = Console.ReadLine().Split(' ');
            string[] menorPosicao = CalculoVetor.Menor_E_Posicao(vetor).Split(',');
            Console.WriteLine("O menor número é " + menorPosicao[0] + " na posição " + menorPosicao[1]);
        }
    }
}