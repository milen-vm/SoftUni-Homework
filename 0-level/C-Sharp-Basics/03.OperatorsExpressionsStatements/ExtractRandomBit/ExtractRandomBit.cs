using System;

class ExtractRandomBit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit to extract: ");
        int bitExt = int.Parse(Console.ReadLine());
        int numRight = num >> bitExt;
        int bit = numRight & 1;
        Console.WriteLine("In binary representation in position {0}, the bit is: {1}", bitExt, bit);
    }
}