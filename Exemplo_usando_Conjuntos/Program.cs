using System;
using System.Collections.Generic;
using Exemplo_usando_Conjuntos.Entities;
using System.IO;

namespace Exemplo_usando_Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            string path = @"C:\temp\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
