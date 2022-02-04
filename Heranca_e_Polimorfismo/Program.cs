using System;
using Heranca_e_Polimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Heranca_e_Polimorfismo {
    class Program {
        static void Main(string[] args) {

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in list) {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach (Account acc in list) {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list) {
                Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2",CultureInfo.InvariantCulture)}");
            }

            //Sealed (palavra chave que evita que a classe seja herdada) Ex: sealed class SavingsAccount : Account
            //Também é possivel usar o sealed em métodos override para que este método não possa ser sobreescrito novamente em outra subclasse

            //Sobreposição: virtual, override e base
            //Palavra Virtual permite que um método seja sobreposto ou sobreescrito nas subclasses
            //Palavra Override sobreescreve um método para que altere o comportamento dele na subclasse
            //Palavra Base chama o método virtual da superclasse
            /*Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);*/

            //Exemplos Upcasting e Downcasting
            /*
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting
            Account acc1 = bacc; //Objeto Account recebendo um objeto BusinessAccount (na herança o objeto BusinessAccount É UM Account)
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); //é possível criar um objeto da subclasse e atribuir a um objeto da superclasse
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01); //o mesmo que o exemplo acima (SavingsAccount é uma subclasse de Account)

            //Downcasting
            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount) acc3;

            if (acc3 is BusinessAccount) {
                BusinessAccount acc5 = (BusinessAccount) acc3; //Casting de BusinessAccount
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount) {
                SavingsAccount acc5 = acc3 as SavingsAccount; //Outra forma de casting usando "as"
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }*/
        }
    }
}
