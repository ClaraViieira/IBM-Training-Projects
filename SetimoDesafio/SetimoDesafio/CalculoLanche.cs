using System;
using System.Globalization;

namespace SetimoDesafio
{
    class CalculoLanche
    {
        public static double ValorTotal(int codigo, int quantidade)
        {
            double total;
            if (codigo == 1)
                total = quantidade * 4.00;
            else if (codigo == 2)
                total = quantidade * 4.50;
            else if (codigo == 3)
                total = quantidade * 5.00;
            else if (codigo == 4)
                total = quantidade * 2.00;
            else
                total = quantidade * 1.50;
            return total;
        }
    }
}
