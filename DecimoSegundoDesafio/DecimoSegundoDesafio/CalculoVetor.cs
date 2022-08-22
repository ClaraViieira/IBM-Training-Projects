using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoSegundoDesafio {
    static class CalculoVetor {
        public static string Menor_E_Posicao(string[] vetor) {
            int menor = int.Parse(vetor[0]);
            int posicao = 0;
            for (int i = 0; i < vetor.Length; i++) {
                if (int.Parse(vetor[i]) < menor) {
                    menor = Convert.ToInt32(vetor[i]);
                    posicao = i;
                }
            }
            return menor.ToString() + "," + posicao.ToString();
        }
    }
}