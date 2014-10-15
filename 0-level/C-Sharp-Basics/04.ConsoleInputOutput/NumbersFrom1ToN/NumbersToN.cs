using System;

 class NumbersToN
{
    static void Main()
    {
        Console.Write("Enter a integer: ");
        int count = int.Parse(Console.ReadLine());
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine(i);
        }
    }
}