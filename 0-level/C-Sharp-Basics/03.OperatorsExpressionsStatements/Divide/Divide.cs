using System;

class Divide
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool isDivided = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine("Divided by 7 and 5? " + isDivided);
    }
}