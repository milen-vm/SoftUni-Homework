using System;
using System.Numerics;

class TrailingZeroes 
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }

        int counter = 0;

        string nString = Convert.ToString(nFactorial);

        for (int i = nString.Length - 1; i >= 0; i--)
        {
            if (nString[i] == '0')
            {
                ++counter;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(counter);

        // Console.WriteLine(nString);
    }
}