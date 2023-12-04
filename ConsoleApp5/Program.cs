using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp5
{
    public class Program
    {
        public static void Main(string[]args)
        {
            string s = "cbacdcbc";
            Console.WriteLine(RemoveDuplicateLetters(s));
        }

        public static string RemoveDuplicateLetters(string s)
        {
            List<char> charList = s.ToList();
            List<char> charsToDelete = new List<char>();
            //First get rid of the dupes
            for (int i = 0; i < charList.Count-1; i++)
            {
                Console.WriteLine("\n" + charList[i]);
                for(int j = i+1; j < charList.Count; j++)
                {
                    Console.WriteLine("Comparing: " + charList[i] + " and " + charList[j]);
                    if(charList[i] == charList[j])
                    {
                        //charList.RemoveAt(i);
                        charsToDelete.Add(charList[i]);
                        break;
                    }
                }
            }

            foreach (char c in charsToDelete)
            {
                charList.Remove(c);
            }
            string solution = ListToStr(charList);
            PrintIntValues(solution);
            return solution;
        }

        public static void PrintIntValues(string s)
        {
            char[] chars = s.ToCharArray();
            
            for(int i =0; i< chars.Length; i++)
            {
                Console.WriteLine("charValue for " + chars[i] + " is " + (int) chars[i]);
            }
        }
        public static char SortByLex(List<char> charList)
        {

            return '\0';
        }
        public static string ListToStr(List<char> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendJoin("", list);
            return sb.ToString();
        }
    }
}
