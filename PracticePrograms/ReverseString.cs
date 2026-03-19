using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string to be reversed");
            string input = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = input.Length - 1; i >=0  ; i--)
            {
                stringBuilder.Append(input[i]);
            }    
            Console.WriteLine("INPUT FROM USER {0}", input);
            Console.WriteLine("REVERSED STRING IS {0}", stringBuilder);
            Console.ReadLine();
        }
    }
}
