using System;

class CheckBit
{
    static void Main()
    {
        Console.Write("Please, enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int bitPos = int.Parse(Console.ReadLine());
        int numRight = num >> bitPos;
        int bit = numRight & 1;
        bool check = (bit == 1) ? true : false;
        Console.WriteLine("The bit on the position {0} has value of 1. {1}.", bitPos, check);
    }
}