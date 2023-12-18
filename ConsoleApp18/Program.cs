using System;

class Program
{
    static void Main()
    {
        int[] a = { 5, 6, 2, 7, 4 };
        Console.WriteLine("Result = " + MaxProductDifference(a));
    }

    public static int MaxProductDifference(int[] nums)
    {
        int result = 0;
        Array.Sort(nums);

        result =  (nums[nums.Length-1] * nums[nums.Length-2]) - (nums[0] * nums[1]);

        return result;
    }
}