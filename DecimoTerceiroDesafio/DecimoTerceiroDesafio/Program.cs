using System;

namespace DecimoTerceiroDesafio {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());
            ConversaoTempo tempo = new ConversaoTempo(valor);
            Console.WriteLine(tempo.Conversao());
        }
    }
}
