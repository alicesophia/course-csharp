using System;
using System.IO;
using System.Collections.Generic;
using Exemplo_usando_Interface_IComparable.Entities;

namespace Exemplo_usando_Interface_IComparable {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\temp\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();    
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    //Sort ordena a lista, mas o objeto da lista tem que implementar interface IComparable
                    list.Sort();
                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
