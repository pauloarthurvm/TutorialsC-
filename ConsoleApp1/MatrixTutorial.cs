using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class MatrixTutorial {

        double[,] matrix;

        public MatrixTutorial() {
            matrix = new double[2, 3];

            Console.WriteLine(matrix.Length); //Quantidade de casas

            Console.WriteLine(matrix.Rank); //Quantidade de linhas

            Console.WriteLine(matrix.GetLength(0)); //Quantidade de linhas

            Console.WriteLine(matrix.GetLength(1)); //Quantidade de colunas
        }
    }
}
