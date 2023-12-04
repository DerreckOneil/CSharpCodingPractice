using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    
    public class Program
    {
        static List<float> floatList = new();
        static List<int> integerList = new();
        static List<int> l2Ints = new();

        public static void Main(string[]args)
        {
            string str = "5.0,100,5.5,101,6.0,200,L2;5.0, 300, 5.5, 301,6.0, 350";
            SplitString(str);
            PrintScreen();
        }

        private static void PrintScreen()
        {
            Console.WriteLine("\t10\t20");
            for(int i =0 ; i < floatList.Count; i++)
            {
                Console.WriteLine(floatList[i] + "\t" + integerList[i] + "\t" + l2Ints[i]);
                
            }
        }

        public static void SplitString(string str)
        {
            char[] seperators = { ';', ',' };
            string[] strings = str.Split(seperators);
            bool nextColumn = false;
            foreach (string s in strings)
            {
                
                if(s.Contains('.'))
                {
                    Console.WriteLine("Decimal found! " + s);
                    floatList.Add(float.Parse(s));

                }
                else if(!s.Contains('L'))
                {
                    Console.WriteLine("Integer found!: " + s);
                    if(nextColumn)
                    {
                        Console.WriteLine("Within the next column!");
                        l2Ints.Add(int.Parse(s));
                    }
                    else
                        integerList.Add(int.Parse(s));
                }
                else if(s.Contains('L'))
                {
                    Console.WriteLine("Next column!");
                    nextColumn = true;
                    floatList.Clear();
                }
                
                //Console.WriteLine(s);
            }
        }

    }
}
