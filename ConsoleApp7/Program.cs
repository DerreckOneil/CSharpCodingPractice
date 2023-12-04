using System;

public class Program
{

    public static void Main()
    {
        int n = 7;
        Console.WriteLine("Factorial value:" + FindFactorial(n));
    }

    //5*4*3*2*1
    static int FindFactorial(int x)
    {
        if (x == 0)
            return 1;
        return x * FindFactorial(x - 1);
    }

}


