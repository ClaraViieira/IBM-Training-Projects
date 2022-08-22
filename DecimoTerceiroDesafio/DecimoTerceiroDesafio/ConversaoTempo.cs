namespace DecimoTerceiroDesafio {
    class ConversaoTempo {
        private int Horas { get; set; }
        private int Minutos { get; set; }
        private int Segundos { get; set; }
        private int Resto { get; set; }
        private int Valor { get; set; }
        public ConversaoTempo(int valor) {
            Valor = valor;
        }
        public string Conversao() {
            Horas = Valor / 3600;
            Resto = Valor % 3600;
            Minutos = Resto / 60;
            Resto = Resto % 60;
            Segundos = Resto;
            return Horas + ":" + Minutos + ":" + Segundos;
        }
    }
}