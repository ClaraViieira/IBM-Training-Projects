using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace SegundoDesafioExtra
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public Aluno(string nome, string endereco, int idade)
        {
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome + "\n" 
                + "Endereço: " + Endereco + "\n" 
                + "Idade: " + Idade);
        }

        public void ImprimirTodasMaterias()
        {
            Console.WriteLine("Insira as notas de matemática, português e geografia, respectivamente, na mesma linha: ");
            string[] notas = Console.ReadLine().Split(' ');
            decimal matematica = decimal.Parse(notas[0], CultureInfo.InvariantCulture);
            decimal portugues = decimal.Parse(notas[1], CultureInfo.InvariantCulture);
            decimal geografia = decimal.Parse(notas[2], CultureInfo.InvariantCulture);
            ImprimirDados();
            Console.WriteLine("Nota de matemática: " + matematica.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "Nota de português: " + portugues.ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "Nota de geografia: " + geografia.ToString("F2", CultureInfo.InvariantCulture) + "\n");
        }
        public void ImprimirNotaMatematica()
        {
            Console.WriteLine("Insira a nota de matemática: ");
            decimal matematica = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ImprimirDados();
            Console.WriteLine("Nota de matemática: " + matematica.ToString("F2", CultureInfo.InvariantCulture));
        }
        public void ImprimirNotaPortugues()
        {
            Console.WriteLine("Insira a nota de português: ");
            decimal portugues = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ImprimirDados();
            Console.WriteLine("Nota de português: " + portugues.ToString("F2", CultureInfo.InvariantCulture));
        }
        public void ImprimirNotaGeografia()
        {
            Console.WriteLine("Insira a nota de geografia: ");
            decimal geografia = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ImprimirDados();
            Console.WriteLine("Nota de geografia: " + geografia.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
