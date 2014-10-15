//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. Examples
using System;

class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("Enter two integer between 1 and 100.");
        Console.Write("n = ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int numK = int.Parse(Console.ReadLine());
        float factN = 1.0f;
        float factK = 1.0f;
        for (int i = 1; i <= numN || i <= numK; i++)
        {
            if (i <= numN)
            {
                factN *= i;
            }
            if (i <= numK)
            {
                factK *= i;
            }    
        }
        Console.WriteLine("n!/k! = {0}", (factN / factK));
    }
}