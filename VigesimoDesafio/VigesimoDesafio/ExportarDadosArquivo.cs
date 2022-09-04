using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace VigesimoDesafio {
    class ExportarDadosArquivo : IExportarDados {
        public void ExportarDado(string[] datas) {
            int i = 0;
            foreach (string data in datas) {
                i++;
                using (StreamWriter sw = File.AppendText(@$"c:\course\file{i}.txt")) {
                    sw.Write(data);
                }
            }
        }
    }
}


