using System;

class Paths
{
    static void Main()
    {
        Point3D point1 = new Point3D(4.56, 16.9, 9);
        Point3D point2 = new Point3D(69, 56.69, 88.14);
        Point3D point3 = Point3D.StartingPoint;

        Path path = new Path(point1, point2, point3);

        Console.WriteLine("Saved path to file: {0}", path);

        Storage.SavePathInFile("path.txt", path);       // file is located Static-Members-And-Namespaces/Paths/bin/Debug/path.txt
        Path loadedPath = Storage.LoadPathFromFile("path.txt");

        Console.WriteLine("Loaded path from file: {0}", loadedPath);
    }
}