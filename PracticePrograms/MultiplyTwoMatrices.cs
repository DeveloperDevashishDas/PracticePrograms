using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class MultiplyTwoMatrices
    {
        static void Main()
        {
            int rows = 2;
            int cols = 2;

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] result = new int[rows, cols];

            // Input first matrix
            Console.WriteLine("Enter elements of First Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input second matrix
            Console.WriteLine("\nEnter elements of Second Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Multiply matrices result[0,0] = matrix1[0,0] * matrix2[0,0]
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }

            // Display result
            Console.WriteLine("\n Matrix After Addition:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
