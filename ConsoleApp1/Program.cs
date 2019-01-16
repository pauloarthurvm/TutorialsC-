using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            MatrixExercise matrix = new MatrixExercise();

            matrix.showMatrix();

            matrix.showAround();

            Console.ReadLine();
        }
    }
}
