using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a integer number: ");
        int num = int.Parse(Console.ReadLine());
        int dig3 = num / 100;
        bool dig3Bool = dig3 % 10 == 7;
        Console.WriteLine("Is third digit 7? " + dig3Bool);
    }
}