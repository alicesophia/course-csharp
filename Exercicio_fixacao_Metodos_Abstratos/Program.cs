using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_fixacao_Metodos_Abstratos.Entities;

namespace Exercicio_fixacao_Metodos_Abstratos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++) {
                
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type.Equals("i")) {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                } else {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            double totalTaxes = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer tp in list) {
                Console.WriteLine(tp);
                totalTaxes += tp.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
