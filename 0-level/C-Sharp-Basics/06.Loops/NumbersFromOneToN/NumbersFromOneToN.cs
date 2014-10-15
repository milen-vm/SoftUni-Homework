//Write a program that enters from the console a positive integer n 
//and prints all the numbers from 1 to n, on a single line, separated by a space. 
using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= num)
        {
            Console.Write(counter + " ");
            counter++;
        }
        Console.WriteLine();
    }
}