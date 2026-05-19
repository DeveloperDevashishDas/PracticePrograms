using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class SmallestElementInaMatrix
    {
        static void Main()
        {
            int[,] matrix = {
            { 12, 45, 7 },
            { 34, 2, 19 },
            { 56, 8, 10 }
            };

            /* Finding initial smallest value. This stores the first element of the matrix into the variable smallest.
            matrix[0,0] = 12
            Why do this ? Because the program needs an initial value to compare other elements against. Then later: If a smaller number is found, smallest gets updated. */
            int smallest = matrix[0, 0];


            /* In C#, a 2D array like a matrix is stored with dimensions, and GetLength() tells you the size of each dimension.
            Why GetLength(0) = rows?
            In a 2D array:Dimension 0 = rows Dimension 1 = columns 0 = Down (rows) 1 = Side(columns)
            matrix.GetLength(0) → number of rows
            matrix.GetLength(1) → number of columns */

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int t = matrix.Length;

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < smallest)
                    {
                        smallest = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Row" + rows);
            Console.WriteLine("Colums" + cols);
            Console.WriteLine("Length" + t);
            Console.WriteLine("Smallest element in the matrix is: " + smallest);
            Console.ReadLine();
        }
    }
}
