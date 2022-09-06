using System;

namespace VigesimoSegundoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira as frases abaixo: ");
            string maiorPalavra = "";
            while (true) {
                string frase = Console.ReadLine();
                string[] palavra = frase.Split(' ');
                foreach (string item in palavra) {
                    int tamanhoPalavra = item.Length;
                    if (item.Length >= maiorPalavra.Length) {
                        maiorPalavra = item;
                    }
                    Console.Write(tamanhoPalavra + "-");
                }
                if (frase == "0")
                    break;
                Console.WriteLine();
            }
            Console.WriteLine("The biggest word: " + maiorPalavra);
        }
    }
}
