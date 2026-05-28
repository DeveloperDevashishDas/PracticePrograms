using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class InterchangetheRowsofaMatrix
    {
        static void Main()
        {
            int rows, cols;

            // Input rows and columns
            Console.Write("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            // Input matrix elements
            Console.WriteLine("Enter matrix elements:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}] : ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Display original matrix
            Console.WriteLine("\nOriginal Matrix:");

            DisplayMatrix(matrix, rows, cols);

            // Input rows to interchange
            Console.Write("\nEnter first row number to interchange: ");
            int row1 = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter second row number to interchange: ");
            int row2 = int.Parse(Console.ReadLine()) - 1;

            // Interchange rows
            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[row1, j];
                matrix[row1, j] = matrix[row2, j];
                matrix[row2, j] = temp;
            }

            // Display updated matrix
            Console.WriteLine("\nMatrix After Interchanging Rows:");

            DisplayMatrix(matrix, rows, cols);
        }

        // Method to display matrix
        static void DisplayMatrix(int[,] matrix, int rows, int cols)
        {
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
