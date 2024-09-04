using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 3] 
                    
                    { { 2, 3, 4 }, 
                      { 1, 4, 6 } };

            PrintArrayMatrix(matrix);
        }

        static void PrintArrayMatrix(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
