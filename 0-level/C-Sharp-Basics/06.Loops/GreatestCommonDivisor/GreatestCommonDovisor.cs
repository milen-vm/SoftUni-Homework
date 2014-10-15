//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet). 
using System;

class GreatestCommonDovisor
{
    static void Main()
    {
        Console.WriteLine("Enter two integrs:");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int rest;
        do
        {
            rest = a % b;
            a = b;
            b = rest;
        } 
        while (rest > 0);
        Console.WriteLine("GCD(a,b) " + a);
    }
}