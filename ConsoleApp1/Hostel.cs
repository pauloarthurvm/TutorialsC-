using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Hostel {
        Student[] students;

        public Hostel(int size) {
            students = new Student[size];
        }

        public void addStudent() {
            Console.Write("Student's room: ");
            int room = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            students[room] = new Student(name, email);
            Console.WriteLine();
        }

        public void showStudents() {
            for(int i = 0; i < students.Length; i++) {
                if(students[i] == null) {
                    Console.WriteLine("Quarto " + i + " vazio.");
                } else {
                    Console.WriteLine("Quarto " + i + ": " + students[i].name + " " + students[i].email);
                }
            }
            Console.WriteLine();
        }
    }
}
