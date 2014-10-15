//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.
using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        BigInteger number;
        bool validNum;
        do
        {
            Console.Write("Enter a positive integer: ");
            string str = Console.ReadLine();
            validNum = BigInteger.TryParse(str, out number);
        } 
        while (number < 0 || validNum);
            
        Console.WriteLine("Is prime? " + PrimeCheck(number));
    }
    static bool PrimeCheck(BigInteger num)
    {
        bool isPrime = true;
        double rootNum = Math.Sqrt((double)num);
        for (int i = 2; i <= rootNum; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}