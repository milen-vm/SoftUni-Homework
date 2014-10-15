using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates of the point.");
        Console.Write("x = ");
        float coorX = float.Parse(Console.ReadLine());
        Console.Write("y = ");
        float coorY = float.Parse(Console.ReadLine());
        bool point = (coorX - 0) * (coorX - 0) + (coorY - 0) * (coorY - 0) <= 4;
        Console.WriteLine("The point is in the circle. " + point);


    }
}