using System;
using System.Globalization;

namespace Exemplo_usando_Interface_IComparable.Entities {
    class Employee : IComparable {

        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] vetor = csvEmployee.Split(',');
            Name = vetor[0];
            Salary = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString() {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) { 
            if (!(obj is Employee)) {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            Employee other = obj as Employee;

            return Name.CompareTo(other.Name);
        }
    }
}
