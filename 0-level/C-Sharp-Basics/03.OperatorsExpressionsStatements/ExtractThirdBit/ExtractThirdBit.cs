using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        int numRight = num >> 3;
        int bit = numRight & 1;
        Console.WriteLine("In binary representation, the third bit is: " + bit);
    }
}