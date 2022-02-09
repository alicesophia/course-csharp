using System;
using Exemplo_Delegate.Entities;
using Exemplo_Delegate.Services;
using System.Collections.Generic;
using System.Linq;

namespace Exemplo_Delegate {

    delegate void BinaryNumericOperation(double n1, double n2);

    class Program {
        static void Main(string[] args) {

            //Exemplo Func
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Criando um Delegate Func que recebe um Product e retorna um string
            //Func<Product, string> func = NameUpper;
            //Func<Product, string> func = p => p.Name.ToUpper();

            //Vai pegar a função original e aplicar em cada elemento a função NameUpper, criando uma nova lista com o resultado da função
            //List<string> result = list.Select(NameUpper).ToList();
            //List<string> result = list.Select(func).ToList();
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); //Expressão lambda inline

            foreach (string s in result) {
                Console.WriteLine(s);
            }
            

            //Exemplo Delegate Action
            /*List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = UpdatePrice;
            //Por ser um Action é usado { } porque é um void
            Action<Product> act = p => { p.Price += p.Price * 0.1; }; //Usando expressão lambda

            //Exemplo de Action
            //list.ForEach(UpdatePrice);
            //list.ForEach(act);
            list.ForEach(p => { p.Price += p.Price * 0.1; }); //Usando expressão lambda

            foreach (Product p in list) {
                Console.WriteLine(p);
            }*/

            //Exemplo Delegate Predicate
            /*List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Predicate é uma função que recebe um objeto e devolve um booleano
            //list.RemoveAll(p => p.Price >= 100.0); //Uso de expressão lambda dentro do remove all
            list.RemoveAll(ProductTest);

            foreach (Product p in list) {
                Console.WriteLine(p);
            }*/

            //Exemplo multicast Delegate
            /*double a = 10;
            double b = 12;

            //O delegate só pode referenciar a funcoes que possuem os mesmos argumentos e o mesmo retorno que ele
            BinaryNumericOperation op = CalculationService.ShowSum;
            //Adicionar outra funcao ao Delegate
            op += CalculationService.ShowMax;

            //double result = op(a, b);
            //double result = op.Invoke(a, b);

            //Também funciona só usando op(a, b)
            op.Invoke(a, b);*/

        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }

        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }

        public static bool ProductTest(Product p) {
            return p.Price >= 100.0;
        }

    }
}
