using System;

public class Program
{
    static void Main()
    {
        int[] a = { 3, 2, 2, 3 };
        Console.WriteLine(RemoveElement(a, 3));
    }
    public static int RemoveElement(int[] nums, int val)
    {
        List<int> list = new List<int>();
        list = nums.ToList();
        list.RemoveAll(x => x == 3);
        
        nums = list.ToArray();
        Console.WriteLine(PrintArray(nums));
        return list.Count;
    }

    public static string PrintList(List<int> list) => String.Join(",", list);
    public static string PrintArray(int[]a) => String.Join(",", a);
}