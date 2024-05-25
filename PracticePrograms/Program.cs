using System;

namespace PracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int a, b, result;
                Console.WriteLine("1st Number");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2nd Number");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Operation + - / *");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = a + b;
                        Console.WriteLine("{0}", result);
                        break;

                    case "-":
                        result = a - b;
                        Console.WriteLine("{0}", result);
                        break;

                    case "*":
                        result = a * b;
                        Console.WriteLine("{0}", result);
                        break;

                    case "/":
                        result = a / b;
                        Console.WriteLine("{0}", result);
                        break;

                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }

    }
}
