using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace DesafioExtra
{
    class Calculadora
    {
        public void CalculadoraIMC()
        {
            double altura, peso, IMC;
            Console.Write("Calculadora IMC" + "\n" + "Digite sua altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            IMC = (peso / (altura * altura));
            if (IMC < 17.0)
                Console.WriteLine("Classificação: Muito abaixo do peso");
            else if (IMC < 18.49)
                Console.WriteLine("Classificação: Abaixo do peso");
            else if (IMC < 24.99)
                Console.WriteLine("Classificação: Peso normal");
            else if (IMC < 29.99)
                Console.WriteLine("Classificação: Acima do Peso");
            else if (IMC < 34.99)
                Console.WriteLine("Classificação: Obesidade I");
            else if (IMC < 39.99)
                Console.WriteLine("Classfificação: Obesidade II (severa)");
            else
                Console.WriteLine("Classificação: Obesidade III (móbida)");
        }
        public void CalculadoraArea()
        {
            double raio, area;
            Console.Write("Calculadora Área Círculo" + "\n" + "Digite o raio do círculo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = Math.PI * Math.Pow(raio, 2.0);
            Console.WriteLine("Área do círculo: " + area.ToString("F2", CultureInfo.InvariantCulture));
        }
        public void CalculadoraRegraTres()
        {
            double A, B, C, D;
            Console.Write("Calculadora Regra de Três" + "\n" + "Digite o valor de A: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de C: ");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = (B * C) / A;
            Console.WriteLine("O resultado de D é: " + D.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
