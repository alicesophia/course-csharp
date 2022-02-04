using System;
using System.IO;
using System.Globalization;

namespace Exercicio_fixacao_Manipulacao_de_Arquivos {
    class Program {
        static void Main(string[] args) {

            //Exercício de fixação sobre manipulação de arquivos
            string sourcePath = @"c:\temp\csv";
            string targetPath = sourcePath + @"\out";
            string sourceFile = sourcePath + @"\source.csv";
            string targetFile = targetPath + @"\summary.csv";

            try {
                Directory.CreateDirectory(targetPath);               

                string[] produtos = File.ReadAllLines(sourceFile);
                using (StreamWriter sw = File.AppendText(targetFile)) {
                    foreach (string p in produtos) {
                        string[] dadosProdutos = p.Split(",");
                        double preco = double.Parse(dadosProdutos[1], CultureInfo.InvariantCulture);
                        int qtd = int.Parse(dadosProdutos[2]);
                        double total = preco * qtd;
                        sw.WriteLine($"{dadosProdutos[0]},{total.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }

            } catch (IOException e) {
                Console.WriteLine("Erro na operação!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
