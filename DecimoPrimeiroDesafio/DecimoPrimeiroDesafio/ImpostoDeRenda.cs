using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DecimoPrimeiroDesafio {
    class ImpostoDeRenda {
        public double Salario { get; set; }
        public ImpostoDeRenda(double salario) {
            Salario = salario;
        }
        public double Imposto() {
            double[] primeiraFaixa = new double[] { 0, 2000 };
            double[] segundaFaixa = new double[] { 2000.01, 3000 };
            double[] terceiraFaixa = new double[] { 3000.01, 4500 };
            if (Salario > primeiraFaixa[0] && Salario <= primeiraFaixa[1])
                return 0;
            else if (Salario >= segundaFaixa[0] && Salario <= segundaFaixa[1])
                return (Salario - 2000) * 0.08;
            else if (Salario >= terceiraFaixa[0] && Salario <= terceiraFaixa[1])
                return (Salario - 3000) * 0.18 + 1000 * 0.08;
            else
                return (Salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
        }
        public override string ToString() {
        double valor = Imposto();
            return valor == 0 ? "Isento" : "R$ " + valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
