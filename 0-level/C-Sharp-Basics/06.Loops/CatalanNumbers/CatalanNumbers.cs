//Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer \"n\", 1 < n < 100.");
        int n;
        do
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
        } 
        while (!(n >= 0 && n <= 100));
        BigInteger divided = 1;
        BigInteger divisor = 1;
        for (int i = (n + 2); i <= (2 * n); i++)
        {
            divided *= i;
        }
        while (n > 0)
        {
            divisor *= n;
            n--;
        }
        Console.WriteLine("(2n)!/((n + 1)! * n!) = " + (divided / divisor));
    }
}
