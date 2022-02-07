using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicio_fixacao_Dictionary {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, int> votes = new Dictionary<string, int>();

            string path = @"C:\temp\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        
                        string name = line[0];                        
                        int vote = int.Parse(line[1]);
                        
                        if (votes.ContainsKey(name)) {
                            votes[name] += vote;
                        } else {
                            votes[name] = vote;
                        }

                    }
                    
                    foreach (KeyValuePair<string, int> i in votes) {
                        Console.WriteLine($"{i.Key}: {i.Value}");
                    }

                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
