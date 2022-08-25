using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoQuintoDesafio {
    class SomaImpares {
        public int X { get; private set; }
        public int Y { get; private set; }
        public SomaImpares(int x, int y) {
            X = x;
            Y = y;
        }
        public int Soma() {
            int min, max, soma = 0;
            if (X < Y) {
                min = X;
                max = Y;
            }
            else {
                min = Y;
                max = X;
            }
            for (int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    soma += i;
                }
            } 
            return soma;
        }
        public override string ToString() {
            int resultado = Soma();
            return "Soma dos ímpares consecutivos: " + resultado.ToString();
        }
    }
}
