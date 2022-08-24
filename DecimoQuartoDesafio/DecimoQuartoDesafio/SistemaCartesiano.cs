using System;

namespace DecimoQuartoDesafio {
    class SistemaCartesiano {
        public int X { get; private set; }
        public int Y { get; private set; }
        public SistemaCartesiano(int x, int y) {
            X = x;
            Y = y;
        }
        public string PlanoCartesiano() {
            if (X == 0 || Y == 0)
                return "Nulo";
            else if (X > 0 && Y > 0)
                return "Primeiro quadrante";
            else if (X < 0 && Y > 0)
                return "Segundo quadrante";
            else if (X < 0 && Y < 0)
                return "Terceiro quadrante";
            else
                return "Quarto quadrante";
        }
        public override string ToString() {
            string resultado = PlanoCartesiano();
            return resultado;
        }
    }
}