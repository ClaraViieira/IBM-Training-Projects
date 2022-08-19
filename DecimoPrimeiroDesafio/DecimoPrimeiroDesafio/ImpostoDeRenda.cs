using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DecimoPrimeiroDesafio {
    class ImpostoDeRenda {
        public double Salario { get; private set; }
        public ImpostoDeRenda(double salario) {
            Salario = salario;
        }
        private double Imposto() {
            double[] Faixa = new double[] { 0, 2000, 2000.01, 3000, 3000.01, 4500 };
            if (Salario > Faixa[0] && Salario <= Faixa[1])
                return 0;
            else if (Salario >= Faixa[2] && Salario <= Faixa[3])
                return (Salario - 2000) * 0.08;
            else if (Salario >= Faixa[4] && Salario <= Faixa[5])
                return (Salario - 3000) * 0.18 + 1000 * 0.08;
            else
                return (Salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
        }
        public override string ToString() {
        double valor = Imposto();
            return valor == 0 ? "Isento" : "Imposto igual a R$ " + valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
