using System;

public class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 0, 0, 0 };
        int[] b = { 2, 5, 6 };
        Merge(a, 3, b, 3);
    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int j = 0;
        for (int i = m; i < nums1.Length; i++)
        {
            nums1[i] = nums2[j];
            j++;
        }
        Array.Sort(nums1);
        Console.WriteLine(PrintArray(nums1));

    }
    public static string PrintArray(int[] a) => String.Join(",", a);

}