using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course {
    class Funcionario {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario (int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increseSalary(double percentage) {
            Salary += Salary * percentage / 100;
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
