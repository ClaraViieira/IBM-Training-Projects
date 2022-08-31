using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoNonoDesafio {
    class Musica {
        public int PrimeiroNumero { get; set; }
        public int SegundoNumero { get; set; }
        public int SomaValores { get; set; }

        public Musica(int primeiroNumero, int segundoNumero) {
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
        }

        public string FaixaMusical() {
            SomaValores = PrimeiroNumero + SegundoNumero;
            if (SomaValores == 0)
                return "PROXYCITY";
            if (SomaValores == 1)
                return "P.Y.N.G.";
            if (SomaValores == 2)
                return "DNSUEY!";
            if (SomaValores == 3)
                return "SERVERS";
            if (SomaValores == 4)
                return "HOST!";
            if (SomaValores == 5)
                return "CRIPTONIZE";
            if (SomaValores == 6)
                return "OFFLINE DAY";
            if (SomaValores == 7)
                return "SALT";
            if (SomaValores == 8)
                return "ANSWER!";
            if (SomaValores == 9)
                return "RAR?";
            if (SomaValores == 10)
                return "WIFI ANTENNAS";
            else
                throw new DomainException ("Faixa não encontrada. \nNúmeros inseridos inválidos, por favor digite um número de 0 a 9.");
        }
        public override string ToString() {
            string soma = FaixaMusical();
            return soma; 
        }
    }
}