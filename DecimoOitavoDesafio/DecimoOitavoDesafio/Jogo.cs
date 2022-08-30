using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoOitavoDesafio {
    class Jogo {
        private string PrimeiroJogador { get; set; }
        private string SegundoJogador { get; set; }

        public Jogo(string primeiroJogador, string segundoJogador) {
            PrimeiroJogador = primeiroJogador;
            SegundoJogador = segundoJogador;
        }

        public string Brincadeira() {
            if (PrimeiroJogador == "ataque" && SegundoJogador == "ataque")
                return "Aniquilação mútua!";
            if (PrimeiroJogador == "papel" && SegundoJogador == "papel")
                return "Ambos venceram!";
            if (PrimeiroJogador == "ataque")
                return "Jogador 1 venceu!";
            if (SegundoJogador == "ataque")
                return "Jogador 2 venceu!";
            if (SegundoJogador == "papel")
                return "Jogador 1 venceu!";
            if (PrimeiroJogador == "papel")
                return "Jogador 2 venceu!";
            else
                return "Sem ganhador!";
        }
        public override string ToString() {
            string vencedor = Brincadeira();
            return vencedor;
        }
    }
}
