using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace NonoDesafio {
    class CalculoSalario {
        public double Salario { get; set; }
        public double Percentual { get; set; }
        public double Reajuste { get; set; }
        public double NovoSalario { get; set; }

        public CalculoSalario(double salario)
        {
            Salario = salario;
            if (Salario <= 400.00)
                Percentual = 15.0;
            else if (Salario <= 800.00)
                Percentual = 12.0;
            else if (Salario <= 1200.00)
                Percentual = 10.0;
            else if (Salario <= 2000.00)
                Percentual = 7.0;
            else
                Percentual = 4.0;

            Reajuste = (Salario * Percentual) / 100.00;
            NovoSalario = Salario + Reajuste;
        }
        public override string ToString()
        {
            return "Novo salário: " + NovoSalario.ToString("F2", CultureInfo.InvariantCulture) + "\n"
            + "Reajuste ganho: " + Reajuste.ToString("F2", CultureInfo.InvariantCulture) + "\n"
            + "Em percentual: " + Percentual + "%";
        }
    }
}
