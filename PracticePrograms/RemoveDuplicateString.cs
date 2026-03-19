using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
   public class RemoveDuplicateString
    {
        static void Main()
        {
            //string input = "bangkok";
            //int[] result = new int[input.Length];

            //foreach (var item in input.ToCharArray())
            //{

            //}
            //for (int i = 0; i < input.Length-1; i++)
            //{
            //    for (int j = 0; j < input.Length-1; j++)
            //    {
            //        if (input[i] != input[i + 1])
            //        {
            //            result[j] = input[i];
            //        }
            //    }
            //}

            string input = "Bbangkok Bangkok";
            HashSet<char> hs = new HashSet<char>();
            StringBuilder sb = new StringBuilder();

            foreach (char item in input)
            {
                if (hs.Add(item))
                {
                    sb.Append(item);
                }
            }

            Console.WriteLine("data is {0}",sb);
            Console.ReadLine();
        }
    }
}
