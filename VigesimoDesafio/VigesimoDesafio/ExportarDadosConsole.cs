using System;
using System.Collections.Generic;
using System.Text;

namespace VigesimoDesafio {
    class ExportarDadosConsole : IExportarDados {
        public void ExportarDado(string[] datas) {
            foreach (string data in datas) {
                Console.WriteLine(data);
            }
        }
    }
}
