using System;
using System.Globalization;
using Exemplo_usando_Heranca_e_Polimorfismo.Entities;
using System.Collections.Generic;

namespace Exemplo_usando_Heranca_e_Polimorfismo {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employee = new List<Employee>();

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                string outsourced = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced.Equals("y")) {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employee.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } else {
                    employee.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in employee) {
                Console.WriteLine(emp);
            }

        }
    }
}
