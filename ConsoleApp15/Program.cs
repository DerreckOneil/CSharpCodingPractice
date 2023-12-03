using System;

public class Program
{

    static void Main()
    {
        Console.WriteLine("Number of Games: " + NumberOfMatches(7));
    }
    public static int NumberOfMatches(int n)
    {
        int teams = n;
        int totalGames = 0;

        while (teams > 1)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even!");
                totalGames++;
                teams--;
                n /= 2;
            }
            else
            {
                Console.WriteLine("Odd!");
                totalGames++;
                teams--;
                n = (n - 1) / 2;
            }
        }

        return totalGames;
    }
}

