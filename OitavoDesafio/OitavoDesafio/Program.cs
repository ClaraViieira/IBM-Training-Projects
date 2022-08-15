using System.Globalization;
using System;

namespace OitavoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);
            int valorHoras = CalculoDuracaoJogo.CalculoHoras(horaInicial, minutoInicial, horaFinal, minutoFinal);
            int valorMinutos = CalculoDuracaoJogo.CalculoMinutos(horaInicial, minutoInicial, horaFinal, minutoFinal);
            Console.WriteLine("O JOGO DUROU " + valorHoras + " HORA(S) E " + valorMinutos + " MINUTO(S)");

        }
    }
}