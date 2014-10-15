using System;

class DistanceCalculator
{
    static void Main()
    {
        Point3D firstPoint = new Point3D(-7, -4, 3);
        Point3D secondPoint = new Point3D(17, 6, 2.5);

        double dist = Point3D.CalculateDistance(firstPoint, secondPoint);

        Console.WriteLine(dist);
    }
}
