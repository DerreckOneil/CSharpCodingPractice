using System;

public class Program
{
    static void Main()
    {
        string x = "677733339";
        LargestGoodInteger(x);
    }
    public static string LargestGoodInteger(string num)
    {
        string result = (num.Length >= 3) ? GrabThreeDigits(num) : "";
        Console.WriteLine("The charValues is this: " + result);
        return result;
    }
    public static string GrabThreeDigits(string num)
    {
        char[] x = num.ToCharArray();
        List<string> threeNumList = new List<string>();
        List<char> charValues = num.ToList();
        int duplicates = 0;
        for (int i = 0; i < charValues.Count-1; i++)
        {
            Console.WriteLine("Number of values in the list " + charValues[i] + " " + charValues.Count(x => x == charValues[i]));
            if (charValues[i] == charValues[i + 1])
                duplicates++;
            else
                duplicates = 0;
            if (duplicates == 2)
            {
                threeNumList.Add(MakeThreeCopies(charValues[i]));
                duplicates = 0;
            }
        }

        string expectedValue = (threeNumList.Count ==0) ? "" : (threeNumList.Max());

        return expectedValue;
    }


    public static string MakeThreeCopies(char c)
    {
        string result = "";
        int x = 0;
        while (x < 3)
        {
            result += c.ToString();
            x++;
        }

        Console.WriteLine("Solution: " + result);
        return result;
    }
    public static string PrintOutArray<T>(T[] val) => String.Join("", val);
}