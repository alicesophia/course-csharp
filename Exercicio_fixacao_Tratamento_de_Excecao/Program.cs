using System;
using System.Globalization;
using Exercicio_fixacao_Tratamento_de_Excecao.Entities;
using Exercicio_fixacao_Tratamento_de_Excecao.Entities.Exceptions;

namespace Exercicio_fixacao_Tratamento_de_Excecao {
    class Program {
        static void Main(string[] args) {

            try {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount to withdraw: ");
                acc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine($"New balance: {acc.Balance}");
            } catch (DomainException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
