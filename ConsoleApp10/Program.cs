using System;

public class Program
{

    static void Main()
    {
        ulong num = 111111111111111101;
        Console.WriteLine(num);

        UInt64 num2 = (UInt64)num;
        Console.WriteLine(num2);
        Console.WriteLine(HammingWeight(num2));
    }

    public static int HammingWeight(UInt64 n)
    {
        

        int numberOfOneBits = 0;
        string num = n.ToString();
        Console.WriteLine("ToString: " + (n) + " is this: " + num);
        numberOfOneBits = num.Count(x => x == '1');
        Console.WriteLine(num);

        return numberOfOneBits;
    }
}