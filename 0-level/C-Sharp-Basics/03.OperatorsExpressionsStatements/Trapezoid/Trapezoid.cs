using System;

class Trapezoid
{
    static void Main()
    {
        Console.Write("Enter the size of the first base \"a\" = ");
        float baseA = float.Parse(Console.ReadLine());
        Console.Write("Enter the size of the second base \"b\" = ");
        float baseB = float.Parse(Console.ReadLine());
        Console.Write("Enter the size of the height \"h\" = ");
        float height = float.Parse(Console.ReadLine());
        float area = (baseA + baseB) * height / 2;
        Console.WriteLine("The area of the trapezoid is {0:F2}.", area);
    }
}