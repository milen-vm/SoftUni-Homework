using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter the height of the rectangle: ");
        float height = float.Parse(Console.ReadLine());
        float perimeter, area;
        perimeter = 2 * width + 2 * height;
        area = width * height;
        Console.WriteLine("Perimeter {0:F2}, area {1:F2}.", perimeter, area);
    }
}