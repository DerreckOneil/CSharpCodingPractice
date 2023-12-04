using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAndStringsPractice
{
    // lists, arrays, matrices, and string parsing functions like split()."
    public class Program
    {
        static List<string> strings = new();

        public static void Main(string[]args)
        {
            strings.Add("bbabc");
            strings.Add("ba");
            string combinedString = CombineTheList(strings);
            Console.WriteLine(combinedString);
            Console.WriteLine("Is it a Palandrone???:  " + IsPalindrome(combinedString));
            SplitSomeStr(combinedString);

        }

        public static string CombineTheList(List<string> someList)
        {
            string[] a = someList.ToArray();
            string combinedString = null;
            StringBuilder sb = new StringBuilder();
            combinedString = sb.AppendJoin(null, a).ToString();
            return combinedString;
        }

        public static bool IsPalindrome(string str)
        {
            char[] chars = str.ToCharArray();
            for(int i=0; i < str.Length/2; i++)
            {
                if (chars[i] == chars[str.Length - (1 + i)])
                    continue;
                else
                {
                    Console.WriteLine("It's not a palandrone!: " + str);
                    return false;
                }

            }

            return true;
        }
        public static void SplitSomeStr(string str)
        {
            string[]sub =  str.Split('a', StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in sub)
            {
                Console.WriteLine($"Substring: {s}");
            }
            
        }
    }

}