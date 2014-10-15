//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string.
//The output should be a variable of type long. Do not use the built-in .NET functionality. 
using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string bin = Console.ReadLine();
        long dec = 0L;
        for (int i = bin.Length - 1, power = 0; i >= 0; i--, power++)
        {
            if (bin[i] == '1') 
            {
                dec += (long)Math.Pow(2, power);
            }
        }
        Console.WriteLine("Decimal: " + dec);
    }
}