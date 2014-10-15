//Write a program that enters from the console a positive integer n and prints all the numbers
//from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
using System;

class NotDivisible
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Numbers from 1 to {0} not divisible on 3 and 7:", num);
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}