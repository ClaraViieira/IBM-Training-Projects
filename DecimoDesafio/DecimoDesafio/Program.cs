using System;

namespace DecimoDesafio {
    class Program {
        static void Main(string[] args) {
            string primeiroAnimal = Console.ReadLine();
            string segundoAnimal = Console.ReadLine();
            string terceiroAnimal = Console.ReadLine();
            ClassificacaoAnimal nomeAnimal = new ClassificacaoAnimal(primeiroAnimal, segundoAnimal, terceiroAnimal);
        }
    }
}
