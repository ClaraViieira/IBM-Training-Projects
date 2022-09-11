using System;

namespace VigesimoSextoDesafio {
    class Program {
        static void Main(string[] args) {
            var entrada = Console.ReadLine().Split('=', '+');
            string[] valores = entrada;
            if (valores[0] == "R" || valores[0] == "r") {
                var calculo = int.Parse(valores[2]) - int.Parse(valores[1]);
                Console.WriteLine(calculo);
            }
            else if (valores[1] == "L" || valores[1] == "l") {
                var calculo = int.Parse(valores[0]) - int.Parse(valores[2]);
                Console.WriteLine(calculo);
            }
            else if (valores[2] == "J" || valores[2] == "j") {
                var calculo = int.Parse(valores[0]) + int.Parse(valores[1]);
                Console.WriteLine(calculo);
            }
        }
    }
}
