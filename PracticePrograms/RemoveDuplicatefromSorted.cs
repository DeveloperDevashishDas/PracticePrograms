using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class RemoveDuplicatefromSorted
    {
        static void Main()
        {
            //Sorted List
            int[] a = { 1, 2, 2, 3, 3 };
            int j = 0;
            int[] temp = new int[a.Length];

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != a[i + 1])
                {
                    temp[j] = a[i];
                    j++;
                }
            }
            temp[j] = a[a.Length - 1];
            foreach (var item in temp)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadLine();

        }
    }
}
