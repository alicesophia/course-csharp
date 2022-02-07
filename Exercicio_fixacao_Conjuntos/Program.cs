using System;
using System.Collections.Generic;

namespace Exercicio_fixacao_Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> set = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                set.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                set.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                set.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Total students: {set.Count}");
        }
    }
}
