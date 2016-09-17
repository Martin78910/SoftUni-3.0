using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_Between_Points
{
    
}
public static class MyExtensions
{
    public static double CalcDistance(this Point p, Point q)
    {
        double deltaX = p.X - q.X;
        double deltaY = p.Y - q.Y;

        return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
    }
}

public class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public double Distance(Point q)
    {
        double deltaX = this.X - q.X;
        double deltaY = this.Y - q.Y;

        return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
    }
}

/*
 * Write a method to calculate the distance between twop1 {x1, y1} and p2 {x2, y2}
 * 
 * Write a program to read two points (given as two integers) and print the Euclidean 
 * distance between them
 */
public class DistanceBetweenPoints
{
    private static void Main()
    {
        Point p = ReadPoint();
        Point q = ReadPoint();

        // Console.WriteLine("{0:F3}", p.CalcDistance(q)); // extension method of class Point
        Console.WriteLine("{0:F3}", p.Distance(q));
    }

    private static Point ReadPoint()
    {
        int[] pointCoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Point p = new Point() { X = pointCoordinates[0], Y = pointCoordinates[1] };

        return p;
    }
}
