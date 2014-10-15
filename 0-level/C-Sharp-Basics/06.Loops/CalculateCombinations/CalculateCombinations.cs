//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops
using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main()
    {
        Console.WriteLine("Enter two integers, \"n\" and \"k\", 1 < k < n < 100.");
        int n;
        int k;
        do
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());          
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
        }
        while (!(1 < k && k < n && n < 100));
        
        int diff = n - k;
        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factDiff = 1;
        while (n > 0)
        {
            factN *= n;
            if (k >= n)
            {
                factK *= n;
            }
            if (diff >= n)
            {
                factDiff *= n;
            }
            n--;
        }
        Console.WriteLine("n!/(k! * (n - k)!) = " + (factN / (factK * factDiff)));
       
    }
}