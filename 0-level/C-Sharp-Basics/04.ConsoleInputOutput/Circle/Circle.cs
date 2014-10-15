using System;

class Circle
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double rad = float.Parse(Console.ReadLine());
        double per = 2 * Math.PI * rad;
        double area = Math.PI * rad * rad;
        Console.WriteLine("The perimeter of the circle is: {0:F2}", per);
        Console.WriteLine("The area of the circle is: {0:F2}", area);
    }
}