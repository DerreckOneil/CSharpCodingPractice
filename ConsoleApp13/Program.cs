using System;

public class Program
{
    static void Main()
    {
        string[] a = { "ab", "c" };
        string[] b = { "a", "bc" };
        Console.WriteLine(ArrayStringsAreEqual(a, b));
    }
    public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        return (String.Join("", word1) == String.Join("", word2)); 
    }
}