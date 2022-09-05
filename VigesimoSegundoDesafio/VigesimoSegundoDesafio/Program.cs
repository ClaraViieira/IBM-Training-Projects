using System;

namespace VigesimoSegundoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira as frases abaixo: ");
            string maiorPalavra = "";
            while (true) {
                int tamanhoInicial = 0;
                string frase = Console.ReadLine();
                string[] palavra = frase.Split(' ');
                if (frase == "0")
                    break;
                foreach (string item in palavra) {
                    int tamanhoPalavra = item.Length;
                    if (item.Length >= tamanhoInicial) {
                        tamanhoInicial = item.Length;
                        maiorPalavra = item;
                    }
                    Console.Write(tamanhoPalavra + "-");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The biggest word: " + maiorPalavra);
        }
    }
}
