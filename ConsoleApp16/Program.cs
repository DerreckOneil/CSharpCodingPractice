using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string example = "4206";
        Console.WriteLine(LargestOddNumber(example));
    }
    public static string LargestOddNumber(string num)
    {
        bool containsOdd = (num.Any(x => IsOddNumber(x))) ? true : false;
        if (!containsOdd)
            return "";

        Console.WriteLine("NUMBER: " + num);
        BigInteger parsedInt = 0;
        if (num.Length == 1)
        {
            parsedInt = BigInteger.Parse(num);
            if (IsOddNumber(parsedInt))
                return num;
            else
                return "";
        }

        parsedInt = BigInteger.Parse(num);
        if (IsOddNumber(parsedInt))
            return num;
        else
        {
            return LargestOddNumber(num.Substring(0, FindNearestOddFromRight(num)+1));
        }



    }

    /// <summary>
    /// Returns an index of the nearest odd from the right
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static int FindNearestOddFromRight(string str) 
    {
        List<char> chars = str.ToCharArray().ToList();

        int result = chars.FindLastIndex(x => !(x % 2 == 0));
        Console.WriteLine("index? " + result);
        return result;
    }

    public static bool IsOddNumber(BigInteger num) => !(num % 2 == 0);
}