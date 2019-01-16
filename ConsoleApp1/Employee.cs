using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Employee {
        public int id;
        public string name;
        public double salary;

        public Employee(int id, string name, double salary) {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void raise() {
            Console.Write("Raise in percentage(%): ");
            double raisePct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salary += (salary * (raisePct / 100.00));
        }
    }
}
