using System;

public class Point3D
{
    private double x;
    private double y;
    private double z;
    private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

    public double X
    {
        get
        {
            return this.x;
        }
        set
        {
            this.x = value;
        }
    }

    public double Y
    {
        get
        {
            return this.y;
        }
        set
        {
            this.y = value;
        }
    }

    public double Z
    {
        get
        {
            return this.z;
        }
        set
        {
            this.z = value;
        }
    }

    public static Point3D StartingPoint
    {
        get
        {
            return startingPoint;
        }
    }
    
    public Point3D(double x, double y, double z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    //http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php
    public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
    {
        double distance = Math.Sqrt(Math.Pow((secondPoint.X - firstPoint.X), 2) + Math.Pow((secondPoint.Y - firstPoint.Y), 2) + Math.Pow((secondPoint.Z - firstPoint.Z), 2));
        return distance;
    }

    public override string ToString()
    {
        string result = String.Format("{0}, {1}, {2}", this.x, this.y, this.z);
        return ("{" + result + "}");
    }
}
