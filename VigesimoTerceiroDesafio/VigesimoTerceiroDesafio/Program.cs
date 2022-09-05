using System;

namespace VigesimoTerceiroDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira a dimensão do tabuleiro: ");
            int tabuleiro = int.Parse(Console.ReadLine());
            int dimensaoTotal = tabuleiro * tabuleiro;
            int impar, par;
            if (dimensaoTotal % 2 == 0) {
                impar = dimensaoTotal / 2;
                par = impar;
                Console.WriteLine(impar + " casas brancas e " + par + " casas pretas");
            }
            else {
                par = (dimensaoTotal - 1) / 2;
                impar = par + 1;
                Console.WriteLine(impar + " casas brancas e " + par + " casas pretas");
            }
        }
    }
}
