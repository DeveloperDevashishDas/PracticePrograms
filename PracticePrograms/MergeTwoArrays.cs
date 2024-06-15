using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public  class MergeTwoArrays
    {
        static void Main()
        {
            int[] firstAL = { 1, 2, 2, 3 };
            int[] secondAL = { 4, 5, 5, 5 };

            int firstALLength = firstAL.Length;
            Console.WriteLine("Length of 1st array {0}", firstALLength);
            int secondALLength = secondAL.Length;
            Console.WriteLine("Length of 2nd array {0}", secondALLength);

            int thirdALLength = firstALLength + secondALLength;
            Console.WriteLine("Length of 3rd array {0}", thirdALLength);

            int[] thirdAL = new int[thirdALLength];

            for (int i = 0; i < firstALLength; i++)
            {
                thirdAL[i] = firstAL[i];
            }

            for (int i = 0; i < secondALLength; i++)
            {
                thirdAL[firstALLength + i] = secondAL[i];
            }

            Console.WriteLine("Merged Two Array");

            foreach (var item in thirdAL)
            {
                Console.WriteLine("{0}", item);
            }

            Console.ReadLine();

        }
    }
}
