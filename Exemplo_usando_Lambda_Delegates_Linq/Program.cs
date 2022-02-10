using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using Exemplo_usando_Lambda_Delegates_Linq.Entities;
using System.Linq;

namespace Exemplo_usando_Lambda_Delegates_Linq {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\temp\in.txt";



            try {

                List<Product> products = new List<Product>();

                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] s = sr.ReadLine().Split(',');
                        string name = s[0];
                        double price = double.Parse(s[1], CultureInfo.InvariantCulture);                       

                        products.Add(new Product(s[0], price));
                    }

                    var average = products.Average(products => products.Price);
                    Console.WriteLine("Average price: " + average.ToString("F2", CultureInfo.InvariantCulture));

                    var names = products.Where(products => products.Price < average).OrderByDescending(products => products.Name).Select(products => products.Name);
                    foreach (string s in names) {
                        Console.WriteLine(s);
                    }

                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
