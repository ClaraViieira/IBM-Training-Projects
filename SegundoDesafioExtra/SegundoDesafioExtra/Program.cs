using System;

namespace SegundoDesafioExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bem vindo ao sistema de notas do alunos!" + "\n" + "Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o endereço do aluno: ");
            string endereco = Console.ReadLine();
            Console.Write("Digite a idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, endereco, idade);

            string opcao = string.Empty;
            bool menu = true; 

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1 - Todas as matérias: ");
                Console.WriteLine("2 - Nota de matemática: ");
                Console.WriteLine("3 - Nota de português: ");
                Console.WriteLine("4 - Nota de geografia: ");
                Console.WriteLine("5 - Encerrar ");

                switch (Console.ReadLine())
                {
                    case "1":
                        aluno.ImprimirTodasMaterias();
                        break;
                    case "2":
                        aluno.ImprimirNotaMatematica();
                        break;
                    case "3":
                        aluno.ImprimirNotaPortugues();
                        break;
                    case "4":
                        aluno.ImprimirNotaGeografia();
                        break;
                    case "5":
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            Console.WriteLine("Programa encerrado com sucesso!");
        }
    }
}
