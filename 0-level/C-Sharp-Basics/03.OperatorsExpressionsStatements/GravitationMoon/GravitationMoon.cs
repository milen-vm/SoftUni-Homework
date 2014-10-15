using System;

class GravitationMoon
{
    static void Main()
    {
        Console.Write("Enter your weight: ");
        float weight = float.Parse(Console.ReadLine());
        Console.WriteLine("Weight on the Moon {1:F2}kg.", weight, weight * 0.17);
    }
}