using System;

class PointInACircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Eenter the coordinates of the point.");
        Console.Write("x = ");
        float coorX = float.Parse(Console.ReadLine());
        Console.Write("y = ");
        float coorY = float.Parse(Console.ReadLine());
        bool pointInCir;
        pointInCir = (coorX - 1) * (coorX - 1) + (coorY - 1) * (coorY - 1) <= 2.25;
        bool pointInRec;
        pointInRec = (-1 <= coorX && coorX <= 5 && -1 <= coorY && coorY <= 1);
            if(pointInCir == true)
            {
                if(pointInRec == true)
                {
                    Console.WriteLine("The point is in the circle but also in the rectangle!");
                }
                else
                {
                    Console.WriteLine("The point is only in the circle.");
                }
            }
            else
            {
                if(pointInRec == true)
                {
                    Console.WriteLine("The point is only in the rectangle!");
                }
                else
                {
                    Console.WriteLine("The point is neither in the rectangle or the circle!");
                }
            }
    }
}