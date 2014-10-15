//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x^2 + … + n!/x^n. Use only one loop. 
//Print the result with 5 digits after the decimal point.
using System;

class CalculateNX
{
    static void Main()
    {
        Console.WriteLine("Enter two integers.");
        Console.Write("n = ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int numX = int.Parse(Console.ReadLine());
        float sum = 1.0f;
        float factN = 1.0f;
        float degreeX = 1.0f;
        for (int i = 1; i <= numN; i++)
        {
            factN *= i;
            degreeX *= numX;
            sum += (factN / degreeX);
        }
        Console.WriteLine("(1!/x) + ... + (n!/x^n) = {0:F5}", sum);
    }
}