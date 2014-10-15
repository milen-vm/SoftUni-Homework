//Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 
using System;

class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter the count of the numbers: ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(i + 1 + " --> ");
            num[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(num);
        Console.WriteLine();
        foreach (var number in num)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}