using System;

class FourDigit
{
    static void Main()
    {
        Console.Write("Enter four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int digitD = number % 10;
        int digitC = (number / 10) % 10;
        int digitB = (number / 100) % 10;
        int digitA = (number / 1000) % 10;
        int sum = digitA + digitB + digitC + digitD;
        Console.WriteLine("sum of digits: " + sum);
        Console.WriteLine("Reversed: " + digitD + digitC + digitB + digitA);
        Console.WriteLine("Last digit in front: " + digitD + digitB + digitC + digitA);
        Console.WriteLine("Second and third digits exchanged: " + digitA + digitC + digitB + digitD);
    }
}
