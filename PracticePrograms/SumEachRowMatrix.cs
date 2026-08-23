using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class SumEachRowMatrix
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
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Find sum of each row
            Console.WriteLine("\nSum of each row:");

            //for (int i = 0; i < rows; i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j < cols; j++)
            //    {
            //        sum += matrix[i, j];
            //    }
            // //i + 1 is used because row numbering for users usually starts from 1
            // Console.WriteLine($"Sum of Row {i + 1} = {sum}");
            //}

            for (int j = 0; j < cols; j++)
            {
                int sum = 0;

                // Add elements of each row for current column
                for (int i = 0; i < rows; i++)
                {
                    sum += matrix[i, j];
                }

             Console.WriteLine($"Sum of Column {j + 1} = {sum}");

            }
        }
    }
}
