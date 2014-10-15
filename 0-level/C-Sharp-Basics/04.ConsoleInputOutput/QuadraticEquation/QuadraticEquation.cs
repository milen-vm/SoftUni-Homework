using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients of the quadratic equation ax^2 + bx + c = 0:");
        Console.Write("a = ");
        float coeffA = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float coeffB = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float coeffC = float.Parse(Console.ReadLine());
        float determ = coeffB * coeffB - 4 * coeffA * coeffC;
        if (determ < 0)
        {
            Console.WriteLine("The quadratic equation has no real roots!");
        }
        else if (determ == 0)
        {
            float rootX12 = -coeffB / (2 * coeffA);
            Console.WriteLine("The quadratic equation has one real root.\nx1 = x2 = {0:F2}", rootX12);
        }
        else
        {
            float rootX1 = (-coeffB + (float)Math.Sqrt(determ)) / (2 * coeffA);
            float rootX2 = (-coeffB - (float)Math.Sqrt(determ)) / (2 * coeffA);
            Console.WriteLine("The quadratic equation has two real roots.\nx1 = {0:F2}\nx2 = {1:F2}.", rootX1, rootX2);
        }
    }
}