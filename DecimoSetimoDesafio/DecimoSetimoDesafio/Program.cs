using System;

namespace DecimoSetimoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira o horário que Bino acordou: ");
            string[] horas = Console.ReadLine().Split(':');
            int hora = int.Parse(horas[0]);
            int minuto = int.Parse(horas[1]);
            CalculoAtraso atraso = new CalculoAtraso(hora, minuto);
            Console.WriteLine(atraso);
        }
    }
}
