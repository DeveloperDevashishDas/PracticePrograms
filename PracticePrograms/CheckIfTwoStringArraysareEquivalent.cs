using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    internal class CheckIfTwoStringArraysareEquivalent
    {
        
        // Check If Two String Arrays are Equivalent
        // word1 = ["ab", "c"], word2 = ["a", "bc"]
        public static string Compare(string[] word)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in word)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }

        static void Main()
        {
            string[] word1 = new string[2] { "ab", "c" };
            string[] word2 = new string[2] { "a", "bc" };

            string s1 = CheckIfTwoStringArraysareEquivalent.Compare(word1);
            string s2 = CheckIfTwoStringArraysareEquivalent.Compare(word2);
            Console.WriteLine("{0}", s1.Equals(s2));
            Console.ReadLine();
        }

    }
}
