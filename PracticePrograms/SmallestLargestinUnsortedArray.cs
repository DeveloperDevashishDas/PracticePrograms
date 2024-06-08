using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class SmallestLargestinUnsortedArray
    {
        public static int Fun(int[] arr, int k)
        {
            Array.Sort(arr);
            return arr[k - 1];
        }


        static void Main()
        {
            int[] a = { 7, 10, 4, 3, 20, 15 };//7, 10, 4, 3, 20, 15  3,4,7,10,15

            //Sorted List Unsorted
            Console.WriteLine("Enter the kth element");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Smallest element is {0} ", Fun(a, k));
            Array.Sort(a);
            
            //Array.Reverse(a);
            //Console.WriteLine("Smallest element is {0} ", a[k-1]);

            Console.ReadLine();

        }


    }
}
