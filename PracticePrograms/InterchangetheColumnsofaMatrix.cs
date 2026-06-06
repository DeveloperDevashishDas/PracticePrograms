using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class InterchangetheColumnsofaMatrix
    {
        static void Main()
        {
            int rows, cols;

            Console.Write("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter matrix elements:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Enter first column number to swap (0-based index): ");
            int col1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second column number to swap (0-based index): ");
            int col2 = Convert.ToInt32(Console.ReadLine());

            // Swap the columns
            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, col1];
                matrix[i, col1] = matrix[i, col2];
                matrix[i, col2] = temp;
            }

            Console.WriteLine("\nMatrix after interchanging columns:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}


