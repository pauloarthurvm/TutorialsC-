using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class MatrixExercise {
        int[,] matrix;
        int lines, columns;
        public MatrixExercise() {
            Console.Write("Lines: ");
            lines = int.Parse(Console.ReadLine());
            Console.Write("Columns: ");
            columns = int.Parse(Console.ReadLine());
            Console.WriteLine();

            matrix = new int[lines, columns];

            for(int i = 0; i < lines; i++) {
                Console.WriteLine("Line " + (i+1) + " - Enter " + columns + " values:");
                string[] values = Console.ReadLine().Split(' ');
                
                for(int j = 0; j < columns; j++) {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            

        }

        public void showMatrix() {
            for (int i = 0; i < lines; i++) {
                for (int j = 0; j < columns; j++) {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void showAround() {
            Console.Write("Value: ");
            int value = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++) {
                for (int j = 0; j < columns; j++) {
                    if(value == matrix[i, j]) {
                        //Up
                        if((i-1) >= 0) {
                            Console.WriteLine("Up: " + matrix[i-1, j]);
                        }
                        //Down
                        if((i+1) < lines) {
                            Console.WriteLine("Down: " + matrix[i+1, j]);
                        }
                        //Left
                        if ((j - 1) >= 0) {
                            Console.WriteLine("Left: " + matrix[i, j-1]);
                        }
                        //Right
                        if ((j + 1) < columns) {
                            Console.WriteLine("Right: " + matrix[i, j+1]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
