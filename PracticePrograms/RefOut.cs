using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class RefOut
    {
        public int add(int a, int b, out int diff, out int div)
        {
            div = b / a;
            diff = a - b;
            return a + b;
        }

        public void cube(ref int x)
        {
            x = x * x * x;
        }
        static void Main(string[] args)
        {
            RefOut obj = new RefOut();
            int diff, div;
            int y = 5;
            obj.cube(ref y);
            Console.WriteLine("Sum is {0}", obj.add(50, 500, out diff, out div));
            Console.WriteLine("Difference is {0}", diff);
            Console.WriteLine("Division is {0}", div);
            Console.WriteLine("Ref Multiple is {0}", y);
            Console.ReadLine();
        }
    }
}
