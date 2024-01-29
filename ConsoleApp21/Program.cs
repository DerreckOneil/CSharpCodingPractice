using System;
using System.Globalization;


public class Program
{
    /*

    */
    private static void Main()
    {
        int[] a = { 2,2 };
        Console.WriteLine(ToString(a));

        Console.WriteLine(ToString(FindErrorNums(a)));


    }

    public static int[] FindErrorNums(int[] nums)
    {
        Dictionary<int, int> mappings = new();
        List<int> solution = new List<int>();
        //bool startingFromOne = nums[0] == 1;
        foreach (int x in nums)
        {
            if (mappings.ContainsKey(x))
            {
                solution.Add(x);
                mappings[x]++; //Value
                if (x == 2 && !(nums[0] == 1))
                    solution.Add(x - 1);
                else
                    solution.Add(x + 1);

            }
            else
                mappings.Add(x, 1);
        }

        foreach (KeyValuePair<int, int> pair in mappings)
            Console.WriteLine("Key: " + pair.Key + " Value: " + pair.Value);

        return solution.ToArray();

    }

    //public static int[] FindErrorNums(int[] nums)
    //{
    //    List<int> list = nums.ToList();
    //    List<int> result = new List<int>();

    //    bool startingFromOne = list[0] == 1;
    //    Console.WriteLine(startingFromOne);

    //    foreach (int x in list)
    //    {
    //        if (list.Count(y => y == x) > 1)
    //        {
    //            result.Add(x);
    //            if (x == 2 && !startingFromOne)
    //                result.Add(x - 1);
    //            else
    //                result.Add(x + 1);
    //        }
    //    }

    //    return result.ToArray();
    //}
    public static string ToString(int[] a) => String.Join(", ", a);

}