using System;
using System.Collections.Generic;
using System.Text;

namespace VigesimoPrimeiroDesafio {
    class Jogo {
        private string _moeda { get; set; }

        public Jogo(string moeda) {
            _moeda = moeda;
        }

        public void TrocaDeMovimento(int movimento) {
            if (movimento == 1) {
                if (_moeda == "A")
                    _moeda = "B";
                else if (_moeda == "B")
                    _moeda = "A";
            }
            else if (movimento == 2) {
                if (_moeda == "B")
                    _moeda = "C";
                else if (_moeda == "C")
                    _moeda = "B";
            }
            else if (movimento == 3) {
                if (_moeda == "A")
                    _moeda = "C";
                else if (_moeda == "C")
                    _moeda = "A";
            }
        }
        public override string ToString() {
            return _moeda;
        }
    }
}
