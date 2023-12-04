using System;

namespace ConsoleApp6
{
    public class InterviewQuestions
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(ReverseAString("qwerty"));
            Console.WriteLine(IsPalindrome("abtba"));
            Console.WriteLine(FindSubstring("abcdefghijklmnop"));
            Console.WriteLine(IsPrimeNumber(21));
            SingletonExample.Instance.DoSomethingA();
        }

        private static string ReverseAString(string a)
        {

            char[] chars = a.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        private static bool IsPalindrome(string a)
        {
            char[] chars = a.ToCharArray();
            for (int i = 0; i < chars.Length / 2; i++)
            {
                if (chars[i] == chars[(chars.Length - 1) - i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private static string FindSubstring(string a)
        {
            string firstFiveChars = "";
            if (a.Length >= 4)
            {
                firstFiveChars = a.Substring(0, 4);
            }
            else
            {
                Console.WriteLine("This isn't above 5 chars");
                return "";
            }

            return firstFiveChars;
        }
        /// <summary>
        /// A prime number is a whole number greater than 1 that cannot be exactly divided by any whole number other than itself and 1 (e.g. 2, 3, 5, 7, 11).
        /// This function will return true if it meets this criteria
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static bool IsPrimeNumber(int a)
        {
            for (int i = 2; i < 10; i++)
            {
                if (i == a)
                    continue;
                else
                {
                    if(a % i == 0)
                    {
                        Console.WriteLine("This number is divisible by: " + i);
                        return false;
                    }
                }
            }

            return true;
        }
    }
}