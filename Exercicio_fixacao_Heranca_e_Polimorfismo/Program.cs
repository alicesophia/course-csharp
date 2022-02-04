using System;
using Exercicio_fixacao_Heranca_e_Polimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_fixacao_Heranca_e_Polimorfismo {
    class Program {
        static void Main(string[] args) {

            List<Product> prodList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type.Equals("i")) {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    prodList.Add(new ImportedProduct(name, price, customsFee));               
                } else if (type.Equals("u")) {
                    Console.Write("Manufacture date  (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    prodList.Add(new UsedProduct(name, price, manufactureDate));
                } else {
                    prodList.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in prodList) {
                Console.WriteLine(prod.PriceTag());
            }
        
        }
    }
}
