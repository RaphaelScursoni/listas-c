using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas {
    class Program {
        static void Main(string[] args) {

            List<Employee> ListEmployee = new List<Employee>();

            Console.WriteLine("How many enployees will be registered? ");
            int Qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < Qtd; i++) {
                Console.WriteLine("Employee: " + i + ":");
                Console.WriteLine("Write Employee ID: ");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Write the name of the employee:");
                string Name = Console.ReadLine();
                Console.WriteLine("Write the salary of employee:");
                double Salary = double.Parse(Console.ReadLine());
                ListEmployee.Add(new Employee(Id, Name, Salary));
            }

            Console.WriteLine("What is the employee ID will be increased salary: ");
            int IdInc = int.Parse(Console.ReadLine());

            Employee test = ListEmployee.Find(x => x.Id == IdInc);
            if (test != null) {
                Console.WriteLine("Enter with the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                test.IncreasedSalary(percentage);
            }
            else {
                Console.WriteLine("This ID does not exist!!");
            }

            Console.WriteLine();
            Console.WriteLine("Update employees: ");
            foreach (Employee obj in ListEmployee) {
                Console.WriteLine(obj);
            }








        } 
    }
}
