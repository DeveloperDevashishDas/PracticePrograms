using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class RemoveVowels
    {
        static void Main()
        {
            string input = "aeiouAEIOUBKK"; //"Hello Codeauri Family. enter a string here to remove 	    all Vowels:";
            string vowels = "aeiouAEIOU";
            string output = "";
            foreach (char item in input)
            {
                if (!vowels.Contains(item))
                {
                    output += item;
                }
            }
            Console.WriteLine("{0}", output);
            Console.ReadLine();
        }
    }
}
