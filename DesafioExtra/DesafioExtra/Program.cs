using System;
using System.Globalization;

namespace DesafioExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            string opcao = string.Empty;
            bool exbirMenu = true;

            while (exbirMenu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opões abaixo: ");
                Console.WriteLine("1 - Calculadora IMC");
                Console.WriteLine("2 - Calculadora Área Círculo");
                Console.WriteLine("3 - Calculadora Regra de 3");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        calc.CalculadoraIMC();
                        break;
                    case "2":
                        calc.CalculadoraArea();
                        break;
                    case "3":
                        calc.CalculadoraRegraTres();
                        break;
                    case "4":
                        exbirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            Console.WriteLine("Programa finalizado com sucesso!");
        }
    }
}
