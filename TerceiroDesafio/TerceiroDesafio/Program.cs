using System;
using System.Globalization;

namespace TerceiroDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
