using System;
using Exemplo_Comparison.Entities;
using System.Collections.Generic;

namespace Exemplo_Comparison.Entities {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Também é possível criar uma variável com a referência a função e depois usar a variável no list.Sort()
            //Comparison<Product> comp = CompareProducts;

            //Mesmo exemplo mas usando expressão Lambda
            //Expressão lambda é uma função e não precisa ser declarada
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //Foi passada uma referência a função sem argumentos (em C# isso se chama Delegate, uma referência a uma função com typesafety)
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list) {
                Console.WriteLine(p);
            }

        }

    }
}