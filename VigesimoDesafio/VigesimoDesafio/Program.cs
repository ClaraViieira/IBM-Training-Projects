using System;
using System.IO;

namespace VigesimoDesafio {
    class Program {
        static void Main(string[] args) {
            InformacaoDosDados info = new InformacaoDosDados(@"c:\course\file.txt");
            string[] datas = info.ConverterDatas();
            info.ExportacaoDeDados(new ExportarDadosConsole(), datas);
            info.ExportacaoDeDados(new ExportarDadosArquivo(), datas);
        }
    }
}
