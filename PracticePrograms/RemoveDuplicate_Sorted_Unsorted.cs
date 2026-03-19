using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class RemoveDuplicate_Sorted_Unsorted
    {
        static void Main()
        {
            //Sorted List Unsorted
            int[] a = { 5, 5, 4, 3, 3, 2 };
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                hs.Add(a[i]);
            }

            foreach (var item in hs)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadLine();

        }
    }
}
