using System;
using System.IO;
using System.Text.RegularExpressions;

static class Storage
{
    public static void SavePathInFile(string fileName, Path path)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.Write(path);
        }
    }

    public static Path LoadPathFromFile(string fileName)
    {
        Path path = new Path();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string input = input = reader.ReadToEnd();
            string pattern = "{([\\d,.]+), ([\\d,.]+), ([\\d,.]+)}";

            Regex regex = new Regex(pattern);

            var matchs = regex.Matches(input);

            if (matchs.Count <= 0)
            {
                throw new ApplicationException("Invalid data in file " + fileName);
            }

            foreach (Match match in matchs)
            {
                double x = double.Parse(match.Groups[1].Value);
                double y = double.Parse(match.Groups[2].Value);
                double z = double.Parse(match.Groups[3].Value);

                Point3D point = new Point3D(x, y, z);
                path.AddPoint(point);
            }

            return path;
        }
    }
}
