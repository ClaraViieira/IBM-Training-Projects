using System;

namespace DecimoSextoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira a altura do pulo e o número de canos desejados: ");
            string[] valores = Console.ReadLine().Split(' ');
            int alturaPulo = int.Parse(valores[0]);
            int qteCanos = int.Parse(valores[1]);
            Console.WriteLine("Insira as alturas dos canos: ");
            string[] saltos = Console.ReadLine().Split(' ');
            int[] pulos = Array.ConvertAll(saltos, int.Parse);
            bool validacao = true;
            for (int i = 0; i < qteCanos - 1; i++)
                if (VerificaPulo(alturaPulo, pulos[i], pulos[i + 1]))
                    validacao = true;
                else
                    validacao = false;
            Console.WriteLine(validacao == true ? "You Win!" : "Game Over");
        }
        private static bool VerificaPulo(int alturaPulo, int alturaCanoAnterior, int alturaCanoProximo) {
            int diferenca = alturaCanoProximo - alturaCanoAnterior;
            if (diferenca < 0)
                diferenca *= -1;
            return diferenca <= alturaPulo ? true : false;
        }
    }
}
