using System;

namespace VigesimoQuintoDesafio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira os dados do evento: ");
            int dia, hora, minuto, segundo, inicio, fim, duracao, resto;
            string[] valores = Console.ReadLine().Split(' ');
            int primeiroDia = int.Parse(valores[1]);
            valores = Console.ReadLine().Split(':');
            int primeiraHora = int.Parse(valores[0]);
            int primeiroMinuto = int.Parse(valores[1]);
            int primeiroSegundo = int.Parse(valores[2]);
            valores = Console.ReadLine().Split(' ');
            int ultimoDia = int.Parse(valores[1]);
            valores = Console.ReadLine().Split(':');
            int ultimaHora = int.Parse(valores[0]);
            int ultimoMinuto = int.Parse(valores[1]);
            int ultimoSegundo = int.Parse(valores[2]);

            inicio = (primeiroDia - 1) * 24 * 60 * 60 + primeiraHora * 60 * 60 + primeiroMinuto * 60 + primeiroSegundo;
            fim = (ultimoDia - 1) * 24 * 60 * 60 + ultimaHora * 60 * 60 + ultimoMinuto * 60 + ultimoSegundo;

            duracao = fim - inicio;

            dia = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            hora = resto / (60 * 60);
            resto = resto % (60 * 60);
            minuto = resto / 60;
            segundo = resto % 60;

            Console.WriteLine(dia + " dia(s)");
            Console.WriteLine(hora + " hora(s)");
            Console.WriteLine(minuto + " minuto(s)");
            Console.WriteLine(segundo + " segundo(s)");
        }
    }
}
