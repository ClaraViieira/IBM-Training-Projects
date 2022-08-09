using System;
using System.Globalization;

namespace QuintoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int DDD = int.Parse(Console.ReadLine());
            if (DDD == 61) {
                Console.WriteLine("Brasília");
            }
            else if (DDD == 71) {
                Console.WriteLine("Salvador");
            }
            else if (DDD == 11) {
                Console.WriteLine("São Paulo");
            }
            else if (DDD == 21) {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (DDD == 32) {
                Console.WriteLine("Juiz de Fora");
            }
            else if (DDD == 19) {
                Console.WriteLine("Campinas");
            }
            else if (DDD == 27) {
                Console.WriteLine("Vitória");
            }
            else if (DDD == 31) {
                Console.WriteLine("Belo Horizonte");
            }
            else {
                Console.WriteLine("DDD não cadastrado");
            }
        }
    }
}
