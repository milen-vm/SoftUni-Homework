//Define a method Fib(n) that calculates the n'th Fibonacci number. 
using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter the n'th Fibonacci number: ");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine(PrintFibonacciNumbers(count));
    }
    static BigInteger PrintFibonacciNumbers(int num)
    {
        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger c = 0;
        for (int i = 1; i <= num; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
}