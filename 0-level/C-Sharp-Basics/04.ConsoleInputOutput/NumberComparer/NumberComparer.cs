using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter a first number: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        float num2 = float.Parse(Console.ReadLine());
        float greater = Math.Max(num1, num2);
        Console.WriteLine("The greater number is: " + greater);
    }
}