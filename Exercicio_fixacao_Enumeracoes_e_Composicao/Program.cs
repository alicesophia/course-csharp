using System;
using System.Globalization;
using Exercicio_fixacao_Enumeracoes_e_Composicao.Entities;
using Exercicio_fixacao_Enumeracoes_e_Composicao.Entities.Enums;

namespace Exercicio_fixacao_Enumeracoes_e_Composicao {
    class Program {
        static void Main(string[] args) {

            //Exercicio fixação Composição e Enumerados
            
            //Entrada de dados
            //Dados do Cliente
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //Dados do Pedido
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            //Instanciação dos objetos
            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, os, client);

            Console.Write("How many items in this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);

                OrderItem orderItem = new OrderItem(prodQuantity, prodPrice, product);

                order.AddItem(orderItem);
            }

            //Saida
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
