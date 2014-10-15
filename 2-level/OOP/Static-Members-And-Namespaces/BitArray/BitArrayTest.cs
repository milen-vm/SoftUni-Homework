using System;

class BitArrayTest
{
    static void Main()
    {
        BitArray bitArr = new BitArray();
        bitArr[99999] = 1;

        Console.WriteLine(bitArr);
    }
}
