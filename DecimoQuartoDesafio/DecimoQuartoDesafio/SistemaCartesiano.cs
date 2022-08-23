using System;

namespace DecimoQuartoDesafio {
    class SistemaCartesiano {
        public static void PlanoCartesiano(string[] valores, int x, int y) {
            if (x == 0 || y == 0)
                Console.WriteLine("Nulo");
            else if (x > 0 && y > 0)
                Console.WriteLine("Primeiro quadrante");
            else if (x < 0 && y > 0)
                Console.WriteLine("Segundo quadrante");
            else if (x < 0 && y < 0)
                Console.WriteLine("Terceiro quadrante");
            else if (x > 0 && y < 0)
                Console.WriteLine("Quarto quadrante");
        }
    }
}
