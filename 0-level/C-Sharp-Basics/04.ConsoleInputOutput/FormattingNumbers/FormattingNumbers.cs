using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter a integer between 0 and 500: ");
        int numA = Int32.Parse(Console.ReadLine());
        Console.Write("Enter floating point number: ");
        float numB = float.Parse(Console.ReadLine());
        Console.Write("Enter another floating point number: ");
        float numC = float.Parse(Console.ReadLine());
        string binA = Convert.ToString(numA, 2).PadLeft(10, '0');
        Console.WriteLine();
        Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:F2}|{3,-10:F3}|", numA, binA, numB, numC);
        Console.WriteLine();
    }
}