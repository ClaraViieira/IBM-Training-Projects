using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoSetimoDesafio {
    class Horario {
        private int Hora { get; set; }
        private int Minuto { get; set; }

        public Horario(int hora, int minuto) {
            Hora = hora;
            Minuto = minuto;
        }

        private int CalcularAtraso() {
            if (Hora == 7)
                return Minuto;
            else if (Hora == 8)
                return 60 + Minuto;
            else if (Hora == 9)
                return 120 + Minuto;
            else
                return 0;
        }

        public override string ToString() {
            return "Atraso máximo em minutos: " + CalcularAtraso();
        }
    }
}
