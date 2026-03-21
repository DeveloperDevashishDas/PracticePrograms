using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class FindDuplicates
    {

        public List<int> Duplicate(int[] numbers)
        {

            HashSet<int> result = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (var item in numbers)
            {
                if (!result.Add(item))
                { 
                    duplicates.Add(item);
                }
            }

            return duplicates;
        }

        static void Main()
        {
            FindDuplicates objFindDuplicates = new FindDuplicates();
            int[] numbers = {2,3,2,3 };
            var result = objFindDuplicates.Duplicate(numbers);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
