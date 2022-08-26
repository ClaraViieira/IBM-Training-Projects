using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoSetimoDesafio.Entities {
    class CalcularAtraso {
        public int Hora { get; private set; }
        public int Minuto { get; private set; }
        public CalcularAtraso(int hora, int minuto) {
            Hora = hora;
            Minuto = minuto;
        }
        private int Atraso() {
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
            int resultado = Atraso();
            return "Atraso maximo em minutos: " + resultado;
        }
    }
}
