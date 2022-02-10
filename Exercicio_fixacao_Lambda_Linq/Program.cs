using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Exercicio_fixacao_Lambda_Linq.Entities;

namespace Exercicio_fixacao_Lambda_Linq {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\temp\in.txt";

            try {

                List<Employee> emp = new List<Employee>();

                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] s = sr.ReadLine().Split(',');
                        string name = s[0];
;                       string email = s[1];
                        double salary = double.Parse(s[2], CultureInfo.InvariantCulture);

                        emp.Add(new Employee(name, email, salary));
                    }

                    Console.WriteLine("Enter salary: ");
                    double minSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine($"Email of people whose salary is more than {minSalary.ToString("F2", CultureInfo.InvariantCulture)}:");

                    var emails = emp.Where(emp => emp.Salary > minSalary).OrderBy(emp => emp.Email).Select(emp => emp.Email);
                    foreach (string s in emails) {
                        Console.WriteLine(s);
                    }

                    var sumSalary = emp.Where(emp => emp.Name[0] == 'M').Sum(emp => emp.Salary);
                    Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumSalary.ToString("F2", CultureInfo.InvariantCulture)}");

                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
