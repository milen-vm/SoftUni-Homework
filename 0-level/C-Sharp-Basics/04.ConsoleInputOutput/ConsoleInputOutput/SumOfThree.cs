using System;

class SumOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers.");
        Console.Write("a = ");
        float firstNum = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float secondNum = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float thirdNum = float.Parse(Console.ReadLine());
        float sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("The sum of a, b and c si: {0:F2}", sum);
    }
}
