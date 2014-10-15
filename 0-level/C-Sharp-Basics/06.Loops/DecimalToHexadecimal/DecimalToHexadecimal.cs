//Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long.
//The output should be a variable of type string. Do not use the built-in .NET functionality. 
using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        long dec = long.Parse(Console.ReadLine());
        string hex = null;
        do
        {
            long rest = dec % 16;
            switch (rest)
            {
                case 10:
                    hex = "A" + hex;
                    break;
                case 11:
                    hex = "B" + hex;
                    break;
                case 12:
                    hex = "C" + hex;
                    break;
                case 13:
                    hex = "D" + hex;
                    break;
                case 14:
                    hex = "E" + hex;
                    break;
                case 15:
                    hex = "F" + hex;
                    break;
                default:
                    hex = rest + hex;
                    break;
            }
            dec /= 16;
        }
        while (dec > 0);
        Console.WriteLine(hex);
    }
}
