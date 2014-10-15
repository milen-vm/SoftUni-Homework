//Using loops write a program that converts an integer number to its binary representation. The input is entered as long.
//The output should be a variable of type string. Do not use the built-in .NET functionality. 
using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        long dec = long.Parse(Console.ReadLine());
        List<int> bin = new List<int>();
        do                                                   //http://www.tu-utc.com/Webpages/E_learning/PIC1/broini_sistemi.htm
        {
            if (dec % 2 == 0)
            {
                bin.Add(0);
            }
            else
            {
                bin.Add(1);
            }
            dec /= 2;
        }
        while (dec > 0);
        Console.Write("Binary: ");
        for (int i = bin.Count - 1; i >= 0; i--)
        {
            Console.Write(bin[i]);
        }
        Console.WriteLine();
    }
}