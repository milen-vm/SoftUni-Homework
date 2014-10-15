using System;
using System.Collections.Generic;

class Path
{
    private List<Point3D> points = new List<Point3D>();

    public List<Point3D> Points
    {
        get
        {
            return this.points;
        }
    }

    public Path(params Point3D[] points)
    {
        if (points.Length > 0)
        {
            this.Points.AddRange(points);
        }
    }

    public void AddPoint(Point3D point)
    {
        this.points.Add(point);
    }

    public override string ToString()
    {
        return string.Join<Point3D>(", ", this.points);
    }
}
