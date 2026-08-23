using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class CheckMatricesEqual
    {
        static void Main()
        {
            //Matrix equality requires: Same dimensions Same element values at same indexes Otherwise matrices are not equal.
            int rows, cols;

            // Input rows and columns
            Console.Write("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];

            // Input first matrix
            Console.WriteLine("\nEnter elements of First Matrix:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}] : ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input second matrix
            Console.WriteLine("\nEnter elements of Second Matrix:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}] : ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Assume matrices are equal
            bool isEqual = true;

            // Compare matrices
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        isEqual = false;
                        break;
                    }
                }

                // Exit outer loop if mismatch found
                if (!isEqual)
                {
                    break;
                }
            }

            // Display result
            if (isEqual)
            {
                Console.WriteLine("\nMatrices are Equal.");
            }
            else
            {
                Console.WriteLine("\nMatrices are Not Equal.");
            }
        }
    }
}
