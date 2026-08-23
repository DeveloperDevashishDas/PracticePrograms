using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class SearchesAnElementInarray
    {
        static void Main()
        {
            int[] numbers = { 20, 10, 40, 60 };
            Console.WriteLine("Enter the element to be found");
            int element = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] == element)
                {
                    Console.WriteLine($"Element found at index {i}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Element not found");
            }

        }
    }

}
