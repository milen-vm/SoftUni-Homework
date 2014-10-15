//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 
using System;

class RandomNumbers
{
    static void Main()
    {
        int min;
        int max;
        do
        {
            Console.WriteLine("Enter range limits:");
            Console.Write("min = ");
            min = int.Parse(Console.ReadLine());
            Console.Write("max = ");
            max = int.Parse(Console.ReadLine());
        } 
        while (min > max);
        Console.Write("Enter count of random numbers: ");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 1; i <= n; i++)
        {
            int num = rnd.Next(min, (max + 1));
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}