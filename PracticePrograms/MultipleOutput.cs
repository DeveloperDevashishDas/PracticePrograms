using System;
using System.Collections.Generic;
using System.Text;

namespace PracticePrograms
{
    public class MultipleOutput
    {   
        /* Out Parameter */
        public void Calculat(int a,int b,out int sum, out int multiply)
        {
            sum = a + b;
            multiply = a * b;
        }

        /* Tuple */
        public (int sum, int product) Calcula(int a, int b)
        {
            return (a + b, a * b);
        }

        /* Dictionery */
        public Dictionary<string,int> Calculate(int a,int b)
         {
            return new Dictionary<string, int> {
                {"sum",a + b },
                {"product", a * b }
            };
         }

        public static void Main()
        {
            MultipleOutput output = new MultipleOutput();
            //output.Calculate(10,20, out int sum, out int product);

            var result = output.Calculate(10, 20);

            Console.WriteLine(result["sum"]);
            Console.WriteLine(result["product"]);

        }
    }
}
