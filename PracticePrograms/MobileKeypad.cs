using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace PracticePrograms
{
    public class MobileKeypad
    {
        public void convert(string input)
        {
            StringBuilder result = new StringBuilder();
            string strresult = "";
            Dictionary<string, string> dic = new Dictionary<string, string>();
           
            dic.Add("2", "A");
            dic.Add("22", "B");
            dic.Add("222", "C");
            dic.Add("3", "D");
            dic.Add("33", "E");
            dic.Add("333", "F");
            dic.Add("4", "G");
            dic.Add("44", "H");
            dic.Add("444", "I");
            dic.Add("5", "J");
            dic.Add("55", "K");
            dic.Add("555", "L");
            dic.Add("6", "M");
            dic.Add("66", "N");
            dic.Add("666", "O");
            dic.Add("7", "P");
            dic.Add("77", "Q");
            dic.Add("777", "R");
            dic.Add("7777", "S");
            dic.Add("8", "T");
            dic.Add("88", "U");
            dic.Add("888", "V");
            dic.Add("9", "W");
            dic.Add("99", "X");
            dic.Add("999", "Y");
            dic.Add("9999", "Z");

            if (input.Contains("*"))
            {
                strresult = input.Substring(0,input.Length-2);
                input = strresult;
            }

            //split 
            string[] wordsList = input.Split(" ");
             
            for (int i = 0; i < wordsList.Length; i++)
            {
                var res = dic.FirstOrDefault(x => x.Key == wordsList[i]).Value;
                result.Append(res);

            }
            Console.Write("output :  {0}", result.ToString());

         }


        //public void convert2(string input)
        //{
        //    StringBuilder result = new StringBuilder();
        //    StringBuilder sequence = new StringBuilder();

        //    Dictionary<string, string> dic = new Dictionary<string, string>();

        //    dic.Add("2", "A");
        //    dic.Add("22", "B");
        //    dic.Add("222", "C");
        //    dic.Add("3", "D");
        //    dic.Add("33", "E");
        //    dic.Add("333", "F");
        //    dic.Add("4", "G");
        //    dic.Add("44", "H");
        //    dic.Add("444", "I");
        //    dic.Add("5", "J");
        //    dic.Add("55", "K");
        //    dic.Add("555", "L");
        //    dic.Add("6", "M");
        //    dic.Add("66", "N");
        //    dic.Add("666", "O");
        //    dic.Add("7", "P");
        //    dic.Add("77", "Q");
        //    dic.Add("777", "R");
        //    dic.Add("7777", "S");
        //    dic.Add("8", "T");
        //    dic.Add("88", "U");
        //    dic.Add("888", "V");
        //    dic.Add("9", "W");
        //    dic.Add("99", "X");
        //    dic.Add("999", "Y");
        //    dic.Add("9999", "Z");
        //    dic.Add("0", "");
        //    char currentChar = 'S';
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        currentChar = input[i];
        //    }

        //    if (sequence.Length == 0 || sequence.charAt(sequence.Length - 1) == currentChar)
        //    {
        //        sequence.Append(currentChar);
        //    }

        //    Console.Write("output :  {0}", result.ToString());
        //}

        public static string ConvertToString(string input)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            List<string> list = new List<string>();
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"2", "A"},
                {"22", "B"},
                {"222", "C" },
                {"3", "D" },
                {"33", "E" },
                {"333", "F" },
                {"4", "G"},
                {"44", "H" },
                {"444", "I" },
                {"5", "J" },
                {"55", "K" },
                {"555", "L" },
                {"6", "M" },
                {"66", "N" },
                {"666", "O" },
                {"7", "P" },
                { "77", "Q"},
                { "777", "R"},
                {"7777", "S" },
                {"8", "T" },
                {"88", "U" },
                {"888", "V" },
                {"9", "W" },
                {"99", "X" },
                {"999", "Y" },
                {"9999", "Z" },
                { "0", "" }
        };

            for (int i = 0; i < input.Length; i++)
            {
                if (sb.Length == 0 || input[i] == input[i - 1])
                {
                    sb.Append(input[i]);
                }
                else
                {
                    if (!char.IsWhiteSpace(input[i]))
                    {
                        if (input[i] == '*')
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }
                        else
                        {
                            sb2.Append(dict[sb.ToString()]);
                            if (input[i] == '#')
                                break;
                            sb = new StringBuilder();
                            sb.Append(input[i]);
                        }
                    }
                    else
                    {
                        sb2.Append(dict[sb.ToString()]);
                        sb = new StringBuilder();
                    }
                }
            }

            return sb2.ToString();
        }
        static void Mai()
        {
            //MobileKeypad obj = new MobileKeypad();
            //Console.WriteLine("Enter Numbers with # towards end");
            //string inn = Console.ReadLine();
            // Console.WriteLine("{0} is {1}", inn, MobileKeypad.ConvertToString(inn));
            //Console.WriteLine("33# {0}", MobileKeypad.ConvertToString("33#"));
            //Console.WriteLine("227*# {0}", MobileKeypad.ConvertToString("227*#"));
            //Console.WriteLine("222 2 22# {0}", MobileKeypad.ConvertToString("222 2 22#"));
            //Console.WriteLine("4433555 555666# {0}", MobileKeypad.ConvertToString("4433555 555666#"));
            //Console.WriteLine("8 88777444666*664# {0}", MobileKeypad.ConvertToString("8 88777444666*664#"));
            //Console.WriteLine("Two Sum");
            //int[] nums = { 2, 6,5, 8, 11 };

            //for (int i = 0; i < a.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < a.Length; j++)
            //    {
            //        if ((a[i] + a[j]) == 14)
            //        {
            //            Console.WriteLine("a[{0}] j[{1}]", a[i], a[j]);
            //        }
            //    }
            //}

            //Array.Sort(nums); // This loses the original indices

           

            Console.Read();
        }

        static async Task Main()
        {
            Console.WriteLine($"Before await - Thread ID: {Environment.CurrentManagedThreadId}");

            await Task.Delay(10000); // Simulates async I/O work

            Console.WriteLine($"After await - Thread ID: {Environment.CurrentManagedThreadId}");
        }


    }
}
