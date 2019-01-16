using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class EmployeeList {
        List<Employee> employees;

        public EmployeeList() {
            employees = new List<Employee>();

            Console.Write("How many employees: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < size; i++) {
                Console.WriteLine("Employee #" + (i+1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: $");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                employees.Add(new Employee(id, name, salary));
            }

            showEmployees();

            Console.Write("Which will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            employees[employees.FindIndex(x => x.id == idIncrease)].raise();

            showEmployees();
        }

        public void showEmployees() {
            Console.WriteLine("List of employees:");
            for(int i = 0; i < employees.Count; i++) {
                Console.WriteLine(employees[i].id + ", " + employees[i].name + ", $" + employees[i].salary.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
        }
    }
}
