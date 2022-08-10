using System;

namespace SextoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ImprimeTabuada(n);
        }
        public static void ImprimeTabuada(int n)
        {
            for (int i = 1; i <= 10; i++) {
                int resultado = i * n;
                Console.WriteLine(i + " x " + n + " = " + resultado);
            }
        }
    }
}
