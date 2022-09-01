using System;
using System.IO;
using System.Text;

namespace VigesimoDesafio {
    class Imprimir : IDatas, IArquivos {
        public void ImprimirDatas() {
            string sourcePath = @"c:\course\date.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try {
                fs = new FileStream(sourcePath, FileMode.Open);
                sr = new StreamReader(fs);
                DateTime line = DateTime.Parse(sr.ReadLine());
                Console.WriteLine(line.ToString("MM/dd/yy"));
                Console.WriteLine(line.ToString("yy/MM/dd"));
                Console.WriteLine(line.ToString("dd-MM-yy"));
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
            finally {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
        public void ImprimirArquivos() {
            string sourcePath = @"c:\course\file.txt";
            string targetPath1 = @"c:\course\file1.txt";
            string targetPath2 = @"c:\course\file2.txt";
            string targetPath3 = @"c:\course\file3.txt";
            try {
                FileStream fs = new FileStream(sourcePath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string[] line = sr.ReadLine().Split('/');
                string dia = line[0];
                string mes = line[1];
                string ano = line[2];
                using (StreamWriter sw = File.AppendText(targetPath1)) {
                    sw.Write(mes + "/" + dia + "/" + ano);
                }
                using (StreamWriter sw = File.AppendText(targetPath2)) {
                    sw.Write(ano + "/" + mes + "/" + dia);
                }
                using (StreamWriter sw = File.AppendText(targetPath3)) {
                    sw.Write(dia + "-" + mes + "-" + ano);
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
