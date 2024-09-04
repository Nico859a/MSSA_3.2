using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = new int[2, 2] { { 5, 6 }, { 7, 8 } };

            int[,] result = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i,j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            PrintMatrix(matrix1);
            PrintMatrix(matrix2);
            Console.WriteLine("Matrix after addition: ");
            PrintMatrix(result);

        }
        static void PrintMatrix(int[,] matrix)
        { 
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
