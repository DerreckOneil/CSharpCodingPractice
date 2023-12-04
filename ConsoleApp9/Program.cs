using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] nums = { 42, 11, 1, 97 };
        Console.WriteLine("Amount of nice pairs: " + CountNicePairs(nums));
        //Rev(17);
    }

    public static int CountNicePairs(int[] nums)
    {
        int nicePairs = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + Rev(nums[j])) == (Rev(nums[i]) + nums[j]))
                    nicePairs++;
            }
        }
        return nicePairs;
    }

    public static int Rev(int num)
    {
        int reversedNum = 0;
        while (num != 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num /= 10;
        }

        return reversedNum;
    }
}

