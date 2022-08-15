using System;
using System.Collections.Generic;
using System.Text;

namespace OitavoDesafio
{
    class CalculoDuracaoJogo
    {
        public static int CalculoHoras(int horaInicial, int minutoInicial, int horaFinal, int minutoFinal)
        {
            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (instanteInicial < instanteFinal)
                duracao = instanteFinal - instanteInicial;
            else 
                duracao = (24 * 60 - instanteInicial) + instanteFinal;

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            return duracaoHoras;
        }
        public static int CalculoMinutos(int horaInicial, int minutoInicial, int horaFinal, int minutoFinal)
        {
            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (instanteInicial < instanteFinal)
                duracao = instanteFinal - instanteInicial;
            else
                duracao = (24 * 60 - instanteInicial) + instanteFinal;

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            return duracaoMinutos;
        }
    }
}
