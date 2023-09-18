using System;

public class Program
{
    public static long countComplementaryPairs(List<string> stringData)
    {
        //StringBuilder sb = new StringBuilder(stringData);


        Console.WriteLine(string.Join(",", stringData));

        int applicablePairs = 0;

        for (int i = 0; i < stringData.Count - 1; i++)
        {
            string newString = stringData[i] + stringData[i + 1];
            if (CanBeRearrangedToBeAPalindrome(newString))
            {
                applicablePairs++;
            }


        }
        return applicablePairs;
    }

    public static bool CanBeRearrangedToBeAPalindrome(string newString)
    {
        //int numOfChars = newString.ToCharArray().Length;

        char[] a = newString.ToCharArray();
        int pairsFound = 0;
        for (int i = 0; i < a.Length / 2; i++)
        {
            Console.WriteLine("Checking: " + a[i] + " and: " + a[i + 1]);
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i].Equals(a[j]))
                {
                    pairsFound++;
                }
            }
            //if(a.Length % 2 == 0)
        }

        Console.WriteLine("Pairs Found: " + pairsFound);
        if (pairsFound == a.Length / 2)
        {
            return true;
        }
        else
            return false;
    }
    
}
