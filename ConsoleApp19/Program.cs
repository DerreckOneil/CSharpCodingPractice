using System;
using System.Text;

public class Program
{
    static void Main()
    {
        string a = "aaabcccd";
        GetLengthOfOptimalCompression(a, 2);
    }
    public static int GetLengthOfOptimalCompression(string s, int k)
    {

        s = GetCondensedString(s);

        return 0;
    }
    public static string GetCondensedString(string s)
    {
        
        List<char> charList = s.ToCharArray().ToList();
        List<string> strs = new List<string>();
        
        for(int i =0; i< charList.Count; i++)
        {
            int iterations = s.Count(x => x == charList[i]);
            if (iterations > 1)
            {
                Console.WriteLine("This char: " + charList[i] + " has iterations: " + iterations);
                string result = string.Concat(charList[i].ToString(),iterations.ToString());
                strs.Add(result);

                int newIndex = charList.LastIndexOf(charList[i]);
                i = newIndex;
                Console.WriteLine("Should the new index be: " + newIndex);
            }
            else
            {
                strs.Add(charList[i].ToString());
            }
        }

        Console.WriteLine(PrintArray(strs.ToArray()));
        return PrintArray(strs.ToArray());
    }

    
    private static string PrintArray(string[] a) => string.Join("", a);
}