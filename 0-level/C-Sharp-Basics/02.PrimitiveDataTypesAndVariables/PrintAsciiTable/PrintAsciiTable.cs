using System;

class PrintAsciiTable
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine(i + " --> \"" + (char)i + "\" in ASCII");
        }
    }
}