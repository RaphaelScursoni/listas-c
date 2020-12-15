using System;
using System.Collections.Generic;
using System.Text;

namespace Listas {
    class Employee {

        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            name = Name;
            id = Id;
            salary = Salary;
        }

        public double IncreasedSalary(double percentage) {
            return Salary += percentage / 100;
        }

        public override string ToString() {
            return "Id Number: "
                + Id
                + "/n"
                + "Name: "
                + Name
                + "/n"
                + "Salary: "
                + Salary;
        }


    }
}
