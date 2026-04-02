using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class CharacterOccurrenceString
    {
        static void Main()
        {
            
            Console.WriteLine("Enter the string whose character occurrence you need");
            string input = Console.ReadLine();
            Dictionary<char,int> count = new Dictionary<char,int>();
            foreach (char c in input) 
            {
                if (count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }
            }

            foreach (var pair in count)
            { 
                Console.WriteLine("Character Count is {0} : {1}", pair.Key,pair.Value );
            }

            Console.ReadLine();
        }
    }
}
