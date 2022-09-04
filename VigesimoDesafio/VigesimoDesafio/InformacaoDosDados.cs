using System;
using System.IO;
using System.Text;

namespace VigesimoDesafio {
    class InformacaoDosDados {
        public string CaminhoArquivo { get; set; }

        public InformacaoDosDados(string caminhoArquivo) {
            CaminhoArquivo = caminhoArquivo;
        }

        public string[] ConverterDatas() {
            DateTime data = DateTime.Parse(File.ReadAllText(CaminhoArquivo));
            return new string[]
            {
                    data.ToString("MM/dd/yy"),
                    data.ToString("yy/MM/dd"),
                    data.ToString("dd-MM-yy")
            };
        }

        public void ExportacaoDeDados(IExportarDados exportarDados, string[] data) {
            exportarDados.ExportarDado(data);
        }
    }
}
