using System;

class OddEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool boolNumber;
        boolNumber = number % 2 == 0;
        Console.WriteLine("Is {0}, odd? {1}", number, !boolNumber);
    }
}