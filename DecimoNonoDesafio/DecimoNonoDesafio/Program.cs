using System;

namespace DecimoNonoDesafio {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Insira a quantidade de vezes que deseja ouvir música: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++) {
                    Console.Write("Insira dois números inteiros de 0 a 9: ");
                    string[] numeros = Console.ReadLine().Split(' ');
                    int primeiroNumero = int.Parse(numeros[0]);
                    int segundoNumero = int.Parse(numeros[1]);
                    Musica musica = new Musica(primeiroNumero, segundoNumero);
                    Console.WriteLine(musica);
                }
            }
            catch (DomainException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
