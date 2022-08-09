using System;
using System.Globalization;

namespace DesafioExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das opões abaixo: ");
            Console.WriteLine("1 - Calculadora IMC");
            Console.WriteLine("2 - Calculadora Área Círculo");
            Console.WriteLine("3 - Calculadora regra de 3");
            Console.WriteLine("4 - Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {
                CalculadoraIMC();
            }

            else if (opcao == 2) {
                CalculadoraArea();
            }

            else if (opcao == 3)  {
                CalculadoraRegra3();
            }
            else {
                Console.WriteLine("Finalizado com sucesso!");
            }

        }
        static void CalculadoraIMC()
        {
            double altura, peso, IMC;
            Console.WriteLine("Calcular o IMC");
            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IMC = (peso / (altura * altura));
            if (IMC < 17.0) {
                Console.WriteLine("Classificação: Muito abaixo do peso");
            }
            else if (IMC < 18.49) {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (IMC < 24.99) {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (IMC < 29.99) {
                Console.WriteLine("Classificação: Acima do Peso");
            }
            else if (IMC < 34.99) {
                Console.WriteLine("Classificação: Obesidade I");
            }
            else if (IMC < 39.99) {
                Console.WriteLine("Classfificação: Obesidade II (severa)");
            }
            else  {
                Console.WriteLine("Classificação: Obesidade III (móbida)");
            }
        }

        static void CalculadoraArea()
        {
            double raio, area, pi = 3.14159;
            Console.WriteLine("Calcular a área de um círculo");
            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = 3.14159 * Math.Pow(raio, 2.0);
            Console.WriteLine("Área do círculo: " + area.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void CalculadoraRegra3()
        {
            int A, B, C, D;
            Console.WriteLine("Calcular por regra de 3");
            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());
            D = (B * C) / A;
            Console.WriteLine("O resultado de D é: " + D);
        }
    }
}
