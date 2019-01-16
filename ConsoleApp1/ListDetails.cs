using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class ListDetails {

        public ListDetails() {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine();

            string s1 = list.Find(test);
            Console.WriteLine("First start with 'A': " + s1);

            string s2 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First start with 'A': " + s2);

            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last start with 'A': " + s3);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First start with 'A' at: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last start with 'A' at: " + pos2);

            Console.WriteLine();

            List<string> list5char = list.FindAll(x => x.Length == 5);

            foreach (string obj in list5char) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();


            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.Add("Maria");
            list.Add("Alex");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.RemoveAt(1);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.RemoveRange(1, 2);

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        public bool test(string name) {
            return name[0] == 'A';
        }
    }
}
