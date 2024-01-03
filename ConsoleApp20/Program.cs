using System;

class Program
{

    static void Main()
    {
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int[] nums2 = new int[6]; 

        RemoveElement(nums, 2);
    }

    public static int RemoveElement(int[] nums, int val)
    {
        List<int> list = nums.ToList();
        list.RemoveAll(x => x == val);
        nums = list.ToArray();
        Console.WriteLine("Solution ["+ PrintArray(nums)+ "]");
        
        Console.WriteLine("Ans: " + nums.Length);
        //nums = list.ToArray();
        return nums.Length;
    }
    public static string PrintArray(int[] a) => String.Join(",", a);
}