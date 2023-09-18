using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestMain
    {

        /*
         * Complete the 'checkMatchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY words1
         *  2. STRING_ARRAY words2
         */
        public static void Main(string[] args)
        {
            string[] a = { "abbcced", "aab", "acc" };
            string[] b = { "abcaaed", "acc", "fqq" };
            List<string> listA = new List<string>(a);
            List<string> listB = new List<string>(b);

            Console.WriteLine(string.Join(',', checkMatchingStrings(listA, listB)));

        }
        public static List<int> checkMatchingStrings(List<string> words1, List<string> words2)
        {
            List<int> solution = new List<int>();
            string[] a = words1.ToArray();
            string[] b = words2.ToArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    solution.Add(1);
                    continue;
                }

                if (!AreOperationsPossible(a[i], b[i]))
                {
                    solution.Add(0);
                }
                else
                {
                    solution.Add(TryOperations(a[i], b[i]));
                }

            }

            return solution;
        }
        public static bool AreOperationsPossible(string a, string b)
        {
            if (a.Length != b.Length)
            {
                Console.WriteLine("These two strings are not even the same length!");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int TryOperations(string a, string b)
        {
            char[] charsA = a.ToCharArray();
            char[] charsB = b.ToCharArray();

            for (int i = 0; i < charsA.Length; i++) //No index OOB
            {
                if (charsA[i] == charsB[i])
                    continue;

                if (i < charsA.Length - 1)
                {
                    if (charsA[i + 1] == charsB[i])
                    {
                        //Do swap operation
                        char temp = charsA[i];
                        charsA[i] = charsA[i + 1];
                        charsA[i + 1] = temp;
                        continue;
                    }
                }
                if (charsA[i] < charsB[i])
                {
                    //Do adding operation
                    while (charsA[i] != charsB[i])
                    {
                        char aChar = charsA[i];
                        int charVal = (int) aChar;
                        charVal++;
                        char nextChar = (char) charVal;
                        charsA[i] = nextChar;
                    }
                    Console.WriteLine("Now they should be equal: " + charsA[i] + " and " + charsB[i]);
                }
                else
                {
                    Console.WriteLine("Can't work with these two chars: " + charsA[i] + " and " + charsB[i]);
                    break; //Leave the loop making the two char arrays not equal
                }



            }

            Console.WriteLine(string.Join(',', charsA));
            Console.WriteLine(string.Join(',', charsB));


            if (charsA.SequenceEqual(charsB))
                return 1;
            else
                return 0;
        }


    }
}
