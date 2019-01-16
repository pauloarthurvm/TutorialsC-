using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class MatrixExample {
        double[,] matrix;
        int size;

        public MatrixExample() {
            Console.WriteLine("Size of the matrix:");
            size = int.Parse(Console.ReadLine());
            matrix = new double[size, size];
            Console.WriteLine();

            for(int i = 0; i < size; i++) {
                for(int j = 0; j < size; j++) {
                    Console.Write("Line " + (i+1) + " - Column: " + (j+1) + ": ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        public void showMainDiagonal() {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if(i == j) {
                        Console.Write(matrix[i, j] + "\t");
                    } else {
                        Console.Write("-\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void negativeNumbers() {
            int count = 0;
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if(matrix[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine(count + " negative numbers");
        }
    }
}
